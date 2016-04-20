using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Campchon.Manager;

namespace Campchon.Worker

{
    class Worker : BackgroundWorker
    {
        public Worker()
        {
            WorkerReportsProgress = true;
            WorkerSupportsCancellation = true;
        }

        public IList<Tuple<string, int, DateTime>> CampSites = new List<Tuple<string, int, DateTime>>();

        protected override void OnDoWork(DoWorkEventArgs e)
        {
            while (!CancellationPending)
            {
                foreach (var campSite in CampSites)
                {
                    string message = null;

                    var canReservation = HttpManager.PossibleReservation(campSite.Item2, campSite.Item3);

                    if (canReservation)
                    {
                        new GcmManager().SendNotification(campSite.Item1,"날짜찾기 성공");
                        message = string.Format("{0} {1}", campSite.Item1, "날짜찾기 성공");
                        ReportProgress(0, message);
                        CancelAsync();
                        break;
                    }

                    message = string.Format("{0} {1}", "자리없음", campSite.Item3);

                    ReportProgress(0, message);
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
