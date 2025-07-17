using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Csharp_Crafting_Calculator
{
    class Custom_UI
    {
        public HintLabel hint_label;
        public Custom_UI(Form parentForm)
        {
            hint_label = new HintLabel(parentForm);
        }
    }
    class HintLabel
    {
        #region 私有字段
        private Form parentForm;         // 父窗体
        private Label messageLabel;      // 显示提示的 Label
        private Timer fadeTimer;         // 控制动画的定时器
        private int stayCounter;         // 停留计时器
        #endregion

        #region 属性
        /// <summary>
        /// 提示文本的字体
        /// </summary>
        public Font MessageFont { get; set; } = new Font("微软雅黑", 10F);

        /// <summary>
        /// 成功提示的颜色（默认绿色）
        /// </summary>
        public Color SuccessColor { get; set; } = Color.FromArgb(0, 128, 0);

        /// <summary>
        /// 错误提示的颜色（默认红色）
        /// </summary>
        public Color ErrorColor { get; set; } = Color.FromArgb(255, 0, 0);

        /// <summary>
        /// 普通提示的颜色（默认黑色）
        /// </summary>
        public Color InfoColor { get; set; } = Color.FromArgb(0, 0, 0);

        /// <summary>
        /// 提示停留的时间（毫秒），默认 2000ms
        /// </summary>
        public int StayDuration { get; set; } = 2000;

        /// <summary>
        /// 动画更新间隔（毫秒），值越小动画越流畅，默认 50ms
        /// </summary>
        public int AnimationInterval { get; set; } = 50;

        /// <summary>
        /// 提示距离窗体底部的像素距离，默认 40px
        /// </summary>
        public int BottomOffset { get; set; } = 40;
        #endregion

        #region 构造函数
        /// <summary>
        /// 初始化淡入淡出提示助手
        /// </summary>
        /// <param name="parentForm">要显示提示的父窗体</param>
        public HintLabel(Form parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponents();
            HookFormEvents();
        }
        #endregion

        #region 初始化方法
        private void InitializeComponents()
        {
            // 创建提示 Label
            messageLabel = new Label
            {
                Text = "",
                AutoSize = true,
                Visible = false,
                ForeColor = Color.Transparent,
                BackColor = Color.Transparent,
                Font = MessageFont,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };
            parentForm.Controls.Add(messageLabel);

            // 创建定时器
            fadeTimer = new Timer
            {
                Interval = AnimationInterval,
                Enabled = false
            };
            fadeTimer.Tick += FadeTimer_Tick;
        }

        private void HookFormEvents()
        {
            // 窗体加载时调整位置
            parentForm.Load += (sender, e) => UpdateMessagePosition();
            // 窗体大小变化时调整位置
            parentForm.Resize += (sender, e) => UpdateMessagePosition();
        }
        #endregion

        #region 核心方法：显示提示
        /// <summary>
        /// 显示普通提示信息（黑色文字）
        /// </summary>
        public void ShowMessage(string message)
        {
            ShowMessage(message, InfoColor);
        }

        /// <summary>
        /// 显示成功提示信息（绿色文字）
        /// </summary>
        public void ShowSuccess(string message)
        {
            ShowMessage(message, SuccessColor);
        }

        /// <summary>
        /// 显示错误提示信息（红色文字）
        /// </summary>
        public void ShowError(string message)
        {
            ShowMessage(message, ErrorColor);
        }

        /// <summary>
        /// 显示自定义颜色的提示信息
        /// </summary>
        public void ShowMessage(string message, Color color)
        {
            // 停止当前动画
            if (fadeTimer.Enabled)
            {
                fadeTimer.Stop();
            }

            // 设置文本和颜色
            messageLabel.Text = message;
            messageLabel.ForeColor = Color.FromArgb(0, color);

            // 更新位置并置于顶层（关键修改！）
            UpdateMessagePosition();
            messageLabel.BringToFront(); // 确保 Label 显示在最上层

            // 初始化动画
            stayCounter = 0;

            // 开始动画
            messageLabel.Visible = true;
            fadeTimer.Start();
        }
        #endregion

        #region 私有方法
        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            stayCounter += AnimationInterval;
            if (stayCounter >= StayDuration)
            {
                fadeTimer.Stop();
                messageLabel.Visible = false;
            }
        }

        private void UpdateMessagePosition()
        {
            // 计算提示位置（底部居中）
            int x = (parentForm.ClientSize.Width - messageLabel.Width) / 2;
            int y = parentForm.ClientSize.Height - BottomOffset;
            messageLabel.Location = new Point(x, y);
        }
        #endregion
    }
}
