using System;

namespace CustomOrderBy.WithIComparable
{
    //Class Player need's to be ordered by score
    //it's can be possible when the class implements IComparable interface
    public class Player : IComparable<Player>
    {
        public string Nickname { get; set; }
        public long Score { get; set; }
        public int CompareTo(Player other)
        {
            if (this.Score < other.Score)
                return 1;
            if (this.Score > other.Score)
                return -1;
            return 0;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Nickname, Score);
        }
    }
}
