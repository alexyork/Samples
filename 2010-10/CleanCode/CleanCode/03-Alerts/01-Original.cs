using System;
using System.Collections.Generic;

namespace CleanCode
{
    public static class AlertFilter
    {
        public static IEnumerable<Alert> FilterByStatus(this IEnumerable<Alert> alerts, int? primaryStatusId, int? secondaryStatusId, bool isNewEntry)
        {
            foreach (var alert in alerts)
            {
                if (alert.PrimaryStatusId.HasValue && alert.SecondaryStatusId.HasValue)
                {
                    if (alert.PrimaryStatusId == primaryStatusId && alert.SecondaryStatusId == secondaryStatusId)
                        yield return alert;
                }
                else if (alert.PrimaryStatusId.HasValue)
                {
                    if (alert.PrimaryStatusId == primaryStatusId && !secondaryStatusId.HasValue)
                        yield return alert;
                }
                else if (alert.SecondaryStatusId.HasValue)
                {
                    if (alert.SecondaryStatusId == secondaryStatusId && !primaryStatusId.HasValue)
                        yield return alert;
                }
                else if (!alert.PrimaryStatusId.HasValue && !alert.SecondaryStatusId.HasValue)
                {
                    if (isNewEntry || primaryStatusId == null & secondaryStatusId == null)
                        yield return alert;
                }
            }
        }
    }

    public class Alert
    {
        public int AlertId { get; set; }
        public int? PrimaryStatusId { get; set; }
        public int? SecondaryStatusId { get; set; }
    }
}
