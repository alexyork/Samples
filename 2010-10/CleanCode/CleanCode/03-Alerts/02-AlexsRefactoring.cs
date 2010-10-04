using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanCode
{
    public static class AlertFilter2
    {
        public static IEnumerable<Alert> FilterByStatus2(this IEnumerable<Alert> alerts,
                                                        int? primaryStatusId,
                                                        int? secondaryStatusId,
                                                        bool isNewEntry)
        {
            var matchingAlerts = from alert in alerts
                                 where alert.PrimaryStatusId == primaryStatusId &&
                                       alert.SecondaryStatusId == secondaryStatusId
                                 select alert;

            var newEntries = from alert in alerts
                             where alert.PrimaryStatusId == null &&
                                   alert.SecondaryStatusId == null &&
                                   isNewEntry
                             select alert;

            return matchingAlerts.Union(newEntries).ToList();
        }
    }
}