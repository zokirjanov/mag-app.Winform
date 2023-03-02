using mag_app.Domain.Constant;

namespace mag_app.Service.Common.Helpers
{
	public static class TimeHelper
	{
		public static DateTime CurrentTime()
		{
			var date = DateTime.UtcNow;
			return date.AddHours(TimeConstatn.UTC);
		}
	}

}
