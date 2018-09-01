using System;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace Shutdown {
	public partial class MainForm : Form {
		int totalSeconds = 0;
		Timer t = new Timer();
		bool isChinese = false;
		ResourceManager res;

		public MainForm() {
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e) {
			Init();
		}

		private void Init() {
			if (CultureInfo.InstalledUICulture.TwoLetterISOLanguageName.ToLower().Equals("zh")) {
				isChinese = true;
			}

			this.Text = (isChinese ? "定时关机" : "Shutdown");
			tabCtrl.TabPages[0].Text = (isChinese ? "指定时间" : "Specific Time");
			tabCtrl.TabPages[1].Text = (isChinese ? "倒计时" : "Count Down");
			label1.Text = (isChinese ? "关机时间" : "Time");
			label2.Text = (isChinese ? "倒数" : "Count down");
			label3.Text = (isChinese ? "小时" : "Hours");
			label4.Text = (isChinese ? "分钟" : "Mins");
			rbHibernate.Text = (isChinese ? "休眠" : "Hibernate");
			rbShutdown.Text = (isChinese ? "关机" : "Shutdown");
			btnConfirm.Text = (isChinese ? "确定" : "OK");

			specifiedTime.Value = DateTime.Now;

			t.Interval = 1000;
			t.Tick += new EventHandler(t_Tick);
		}

		private void countDownHour_MouseClick(object sender, MouseEventArgs e) {
			CountDownHourSelectAll();
		}

		void t_Tick(object sender, EventArgs e) {
			tsslStatus.ForeColor = Color.Blue;

			if (tabCtrl.SelectedIndex == 0) {
				totalSeconds = (int)(specifiedTime.Value - DateTime.Now).TotalSeconds;
			} else {
				totalSeconds -= 1;
			}

			var t = TimeSpan.FromSeconds(totalSeconds);

			tsslStatus.Text = (isChinese ? "剩余: " : "Remaining: ") + string.Format("{0} {1} {2:D2}:{3:D2}:{4:D2}",
				t.Days > 0 ? t.Days + "" : "",
				t.Days > 0 ? (isChinese ? "天" : "day" + (t.Days > 1 ? "s" : "")) : "",
				t.Hours,
				t.Minutes,
				t.Seconds);

			if (totalSeconds < 1) {
				ShutdownOrHibernate();
			}
		}

		private void ShutdownOrHibernate() {
			t.Stop();
			tsslStatus.Text = (rbHibernate.Checked ? (isChinese ? "正在休眠" : "Hibernating...") : (isChinese ? "正在关机" : "Shutting down..."));
			System.Diagnostics.Process.Start(Environment.SystemDirectory + "\\shutdown.exe", rbHibernate.Checked ? "/h" : "/s /f /t 1");
			Application.Exit();
		}

		private void CountDownHourSelectAll() {
			countDownHour.Select(0, countDownHour.Value.ToString().Length);
		}

		private void btnConfirm_Click(object sender, EventArgs e) {
			if (tabCtrl.SelectedIndex == 0) {
				TimeGuard();
			} else {
				CountDown();
			}
		}

		private void TimeGuard() {
			if (btnConfirm.Text == (isChinese ? "确定" : "OK")) {
				if (specifiedTime.Value < DateTime.Now) {
					tsslStatus.ForeColor = Color.Red;
					tsslStatus.Text = (isChinese ? "关机时间不能小于当前时间" : "The shutdown time cannot earlier than current time.");
					return;
				}

				btnConfirm.Text = (isChinese ? "停止" : "Stop");
				rbHibernate.Enabled = rbShutdown.Enabled = false;
				tabCtrl.Enabled = false;

				t.Start();
			} else {
				t.Stop();

				tsslStatus.ForeColor = Color.Green;
				tsslStatus.Text = (isChinese ? "定时关机已停止" : "The scheduled shutdown has been stopped.");

				btnConfirm.Text = (isChinese ? "确定" : "OK");
				rbHibernate.Enabled = rbShutdown.Enabled = true;
				tabCtrl.Enabled = true;
			}
		}

		private void CountDown() {
			if (btnConfirm.Text == (isChinese ? "确定" : "OK")) {
				if (countDownHour.Value < 1 && countDownMinute.Value < 1) {
					tsslStatus.ForeColor = Color.Red;
					tsslStatus.Text = (isChinese ? "倒数时间不能为0" : "Count down cannot be 0");
					countDownHour.Select();
					CountDownHourSelectAll();
					return;
				}

				btnConfirm.Text = (isChinese ? "停止" : "Stop");
				rbHibernate.Enabled = rbShutdown.Enabled = false;
				tabCtrl.Enabled = false;

				totalSeconds = (int)countDownHour.Value * 3600 + (int)countDownMinute.Value * 60;

				t.Start();
			} else {
				t.Stop();

				tsslStatus.ForeColor = Color.Green;
				tsslStatus.Text = (isChinese ? "倒计时已停止" : "Count down has been stopped.");

				btnConfirm.Text = (isChinese ? "确定" : "OK");
				rbHibernate.Enabled = rbShutdown.Enabled = true;
				tabCtrl.Enabled = true;
			}
		}
	}
}
