#if ANDROID
using Android.Content;
using Android.Runtime;

namespace RootBeerFresh
{
    public partial class RootBeer : Com.Kimchangyoun.RootbeerFresh.RootBeer
    {
        protected RootBeer(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public RootBeer(Context? context) : base(context)
        {
        }

        public RootBeer() : base(Microsoft.Maui.ApplicationModel.Platform.CurrentActivity)
        {

        }

        public List<RootItemResult> GetRootItemResults()
        {
            return new List<RootItemResult>
            {
               new ("Root Management Apps", this.DetectRootManagementApps()),
               new("Potentially Dangerous Apps", this.DetectPotentiallyDangerousApps()),
               new("Root Cloaking Apps", this.DetectRootCloakingApps()),
               new("TestKeys", this.DetectTestKeys()),
                new("BusyBoxBinary", this.CheckForBusyBoxBinary()),
                new("SU Binary", this.CheckForSuBinary()),
                new("2nd SU Binary check", this.CheckSuExists()),
                new("For RW Paths", this.CheckForRWPaths()),
                new("Dangerous Props", this.CheckForDangerousProps()),
                new("Root via native check", this.CheckForRootNative()),
                new("Magisk specific checks", this.CheckForMagiskBinary()),
                new("Magisk UDS check", this.CheckForMagiskNative())
            };
        }
    }
}
#endif
