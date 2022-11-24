namespace Calendar.NET
{
    internal class TodayButton : CoolButton
    {
        public TodayButton()
        {
            Size = new System.Drawing.Size(72, 29);
            ButtonText = "Today";
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TodayButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HighlightBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Name = "TodayButton";
            this.ResumeLayout(false);

        }
    }
}
