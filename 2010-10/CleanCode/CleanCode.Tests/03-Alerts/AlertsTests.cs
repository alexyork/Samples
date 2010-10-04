using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace CleanCode.Tests.Alerts
{
    public class AlertsTests
    {
        [TestFixture]
        public class AlertFilterTests
        {
            private IEnumerable<Alert> _alerts;

            [SetUp]
            public void SetUp()
            {
                GenerateMockAlerts();
            }

            [Test]
            public void Should_return_all_alerts_where_both_statuses_are_null()
            {
                var alertsAfterFilter = _alerts.FilterByStatus(null, null, true);

                Assert.AreEqual(1, alertsAfterFilter.Count());
            }

            [Test]
            public void Should_return_all_alerts_where_both_statuses_are_null_or_has_correct_value()
            {
                var alertsAfterFilter = _alerts.FilterByStatus(1, null, true);

                Assert.AreEqual(3, alertsAfterFilter.Count());
            }

            [Test]
            public void Should_return_all_alerts_where_both_statuses_are_null_or_has_correct_externalstatusid()
            {
                var alertsAfterFilter = _alerts.FilterByStatus(null, 2, true);

                Assert.AreEqual(4, alertsAfterFilter.Count());
            }

            [Test]
            public void Should_return_all_alerts_where_both_statuses_are_null_or_has_correct_statusid()
            {
                var alertsAfterFilter = _alerts.FilterByStatus(1, 2, true);

                Assert.AreEqual(2, alertsAfterFilter.Count());
            }

            [Test]
            public void Should_return_all_alerts_where_both_statuses_are_null_and_is_not_new()
            {
                var alertsAfterFilter = _alerts.FilterByStatus(null, null, false);

                Assert.AreEqual(1, alertsAfterFilter.Count());
            }

            [Test]
            public void Should_return_all_alerts_where_statuses_has_correct_value()
            {
                var alertsAfterFilter = _alerts.FilterByStatus(1, null, false);

                Assert.AreEqual(2, alertsAfterFilter.Count());
            }

            [Test]
            public void Should_return_all_alerts_where_externalstatusid_has_correct_value()
            {
                var alertsAfterFilter = _alerts.FilterByStatus(null, 2, false);

                Assert.AreEqual(3, alertsAfterFilter.Count());
            }

            [Test]
            public void Should_return_all_alerts_where_both_statuses_has_correct_value()
            {
                var alertsAfterFilter = _alerts.FilterByStatus(1, 2, false);

                Assert.AreEqual(1, alertsAfterFilter.Count());
            }

            private void GenerateMockAlerts()
            {
                _alerts = new[] {
                              new Alert {AlertId = 1, PrimaryStatusId = null, SecondaryStatusId = null },
                              new Alert {AlertId = 2, PrimaryStatusId = 1, SecondaryStatusId = null},
                              new Alert {AlertId = 3, PrimaryStatusId = 1, SecondaryStatusId = null},
                              new Alert {AlertId = 4, PrimaryStatusId = null, SecondaryStatusId = 2},
                              new Alert {AlertId = 5, PrimaryStatusId = null, SecondaryStatusId = 2},
                              new Alert {AlertId = 6, PrimaryStatusId = null, SecondaryStatusId = 2},
                              new Alert {AlertId = 7, PrimaryStatusId = 1, SecondaryStatusId = 2}
                          };
            }
        }
    }
}
