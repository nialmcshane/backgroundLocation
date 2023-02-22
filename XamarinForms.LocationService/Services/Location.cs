﻿namespace XamarinForms.LocationService.Services
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Xamarin.Essentials;
    using Xamarin.Forms;
    using XamarinForms.LocationService.Messages;

    public class Location
    {
		bool stopping = false;
		public Location()
		{
		}

		public async Task Run(CancellationToken token)
		{
			await Task.Run(async () => {
				while (!stopping)
				{
					stopping = token.IsCancellationRequested;
					try
					{
						await Task.Delay(5000);

						var request = new GeolocationRequest(GeolocationAccuracy.High, TimeSpan.FromSeconds(1));
						var location = await Geolocation.GetLocationAsync(request);
						if (location != null)
						{
							var message = new LocationMessage 
							{
								Latitude = location.Latitude,
								Longitude = location.Longitude
							};

							Device.BeginInvokeOnMainThread(() =>
							{
								MessagingCenter.Send(message, "Location");
							});
						}
					}
					catch (Exception ex)
					{
						Device.BeginInvokeOnMainThread(() =>
						{
							var errormessage = new LocationErrorMessage();
							MessagingCenter.Send(errormessage, "LocationError");
						});
					}
				}
				return;
			}, token);
		}
	}
}
