using System;

namespace Core
{
    public struct Square : IEquatable<Square>
    {
        public int NearbyBombs { get; internal set; }
        public SquareFlags Status { get; private set; }

        public Square(SquareFlags status, int nearbyBombs) {
            Status = status;
            NearbyBombs = nearbyBombs;
        }


        internal void SetBomb() {
            Status |= SquareFlags.Bomb;
        }

        public void ToggleFlag() {
            Status ^= SquareFlags.Flagged;
        }

        public void Dig() {
            Status |= SquareFlags.Dug;

            if (Status.HasFlag(SquareFlags.Bomb))
                Status |= SquareFlags.Exploded;
        }


        public bool Equals(Square other) {
            return other.Status.Equals(Status) && other.NearbyBombs.Equals(NearbyBombs);
        }

        public override bool Equals(object obj) {
            if (obj is Square s) return Equals(s);
            return false;
        }

        public static bool operator ==(Square left, Square right) {
            return left.Equals(right);
        }

        public static bool operator !=(Square left, Square right) {
            return !(left == right);
        }

        public override int GetHashCode() {
            return Status.GetHashCode() + NearbyBombs.GetHashCode();
        }


    }
}