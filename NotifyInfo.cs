using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win10Toast
{
    public enum ShowPosition
    {
        BottomRight,
        TopRight,
        TopLeft,
        BottomLeft
    }

    public enum ShowDirection
    {
        Horizontal,
        Vertical
    }
    public struct NotifyInfo
    {
        public NotifyInfo(int waitingTime)
        {
            this.WaitingTime = waitingTime;
            this.Title = "";
            this.Image = null;
            this.Link = "";
            this.Description = "";
            this.Position = ShowPosition.BottomRight;
            this.Direction = ShowDirection.Horizontal;
        }

        public ShowPosition Position { get; set; }
        public ShowDirection Direction { get; set; }

        /// <summary>
        /// Title notification
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Link for executing file
        /// </summary>
        public string Link { get; set; }
        public Image Image { get; set; }

        /// <summary>
        /// Wait time (second)
        /// </summary>
        public int WaitingTime { get; set; }
    }
}
