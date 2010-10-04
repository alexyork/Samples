using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCode
{
    public static class AlertFilter3
    {
        public static IEnumerable<Alert> FilterByStatus3(this IEnumerable<Alert> alerts, int? primaryStatusId,
                                                         int? secondaryStatusId, bool isNewEntry)
        {
            var filteredAlerts = alerts.WherePrimaryStatusIs(primaryStatusId)
                                       .AndSecondaryStatusIs(secondaryStatusId);

            var newEntryAlerts = alerts.WherePrimaryStatusIs(null)
                                       .AndSecondaryStatusIs(null)
                                       .AndIsNewEntry(isNewEntry);

            return filteredAlerts.Union(newEntryAlerts).ToArray();
        }

        public static IEnumerable<Alert> WherePrimaryStatusIs(this IEnumerable<Alert> alerts, int? primaryStatusId)
        {
            return alerts.Where(a => a.PrimaryStatusId == primaryStatusId);
        }

        public static IEnumerable<Alert> AndSecondaryStatusIs(this IEnumerable<Alert> alerts, int? secondaryStatusId)
        {
            return alerts.Where(a => a.SecondaryStatusId == secondaryStatusId);
        }

        public static IEnumerable<Alert> AndIsNewEntry(this IEnumerable<Alert> alerts, bool isNewEntry)
        {
            return alerts.Where(a => isNewEntry);
        }
    }
}
