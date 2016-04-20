using System;
using System.Linq;
using System.Windows.Forms;

namespace Campchon
{
    public partial class Main : Form
    {
        private readonly Worker.Worker _worker = new Worker.Worker();

        public Main()
        {
            InitializeComponent();
            lbCamp.Items.Add(new Tuple<string, int>("휴림오토캠핑장", 60162));
            lbCamp.SelectedIndex = 0;

            _worker.ProgressChanged += worker_ProgressChanged;
            _worker.RunWorkerCompleted += worker_RunWorkerCompleted;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var reservationString = string.Format("{0} | {1}",
                ((Tuple<string, int>)lbCamp.SelectedItem).Item1, monthCalendar1.SelectionStart.ToString("yyyy/MM/dd"));

            lbReservation.Items.Add(
                new Tuple<string, int, DateTime>(reservationString, ((Tuple<string, int>)lbCamp.SelectedItem).Item2, monthCalendar1.SelectionStart));
            lbReservation.DisplayMember = "Item1";
        }

        private void btnStartReservation_Click(object sender, EventArgs e)
        {
            if (btnStartReservation.Text == "예약시작")
            {
                _worker.CampSites =
                    (from object item in lbReservation.Items select (Tuple<string, int, DateTime>)item).ToList();
                _worker.RunWorkerAsync();

                btnStartReservation.Text = "예약중지";
            }
            else
            {
                _worker.CancelAsync();
            }
            
        }

        #region worker

        private void worker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if (txtLog.Lines.Length <= 30)
            {
                Util.Logging(txtLog, e.UserState.ToString());
            }
            else
            {
                txtLog.Clear();
                Util.Logging(txtLog, e.UserState.ToString());
            }
        }

        private void worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Util.Logging(txtLog, "완료~!!");
            btnStartReservation.Enabled = true;
            btnStartReservation.Text = @"예약시작";
        }

        #endregion
    }
}
