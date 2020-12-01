using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Xamarin.Facebook.Login.Widget;
using System.Collections.Generic;
using Xamarin.Facebook;
using Java.Lang;
using Firebase.Auth;
using Firebase;
using Android.Content;
using Xamarin.Facebook.Login;
using Android.Gms.Tasks;

namespace MobileApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, IFacebookCallback, IOnSuccessListener, IOnFailureListener
    {
        TextView usernameText, emailText, photoText;
        LoginButton facebookLoginButton;
        ICallbackManager callBackManager;

        FirebaseAuth firebaseAuth;
        private bool usingFirebase;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            usernameText = (TextView)FindViewById(Resource.Id.usernameText);
            emailText = (TextView)FindViewById(Resource.Id.emailText);

            facebookLoginButton = (LoginButton)FindViewById(Resource.Id.loginButton);
            facebookLoginButton.SetReadPermissions(new List<string> { "public_profile", "email" });

            callBackManager = CallbackManagerFactory.Create();
            facebookLoginButton.RegisterCallback(callBackManager, this);
            firebaseAuth = GetFirebaseAuth();
        }

        FirebaseAuth GetFirebaseAuth()
        {
            var app = FirebaseApp.InitializeApp(this);
            FirebaseAuth mauth;

            if(app == null)
            {
                var options = new FirebaseOptions.Builder()
                    .SetProjectId("mobile-app-297100")
                    .SetApplicationId("mobile-app-297100")
                    .SetApiKey("AIzaSyB9vKv4le19pNbzOH3zSPixlh3Uo-xK3bI")
                    .SetDatabaseUrl("https://mobile-app-297100.firebaseio.com")
                    .SetStorageBucket("mobile-app-297100.appspot.com")
                    .Build();

                app = FirebaseApp.InitializeApp(this, options);
                mauth = FirebaseAuth.Instance;
            }
            else
            {
                mauth = FirebaseAuth.Instance;
            }

            return mauth;
            
        }

        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            callBackManager.OnActivityResult(requestCode, (int)resultCode, data);
        }

        public void OnCancel()
        {
        }

        public void OnError(FacebookException error)
        {
        }

        public void OnSuccess(Object result)
        {
            if (!usingFirebase)
            {
                usingFirebase = true;
                LoginResult loginResult = result as LoginResult;
                var credentials = FacebookAuthProvider.GetCredential(loginResult.AccessToken.Token);
                firebaseAuth.SignInWithCredential(credentials).AddOnSuccessListener(this)
                    .AddOnFailureListener(this);
            }
            else
            {
                Toast.MakeText(this, "Login successful", ToastLength.Short).Show();
                usingFirebase = false;

                emailText.Text = firebaseAuth.CurrentUser.Email;
                usernameText.Text = firebaseAuth.CurrentUser.DisplayName;
            }
          
        }

        public void OnFailure(Exception e)
        {

        }
    }
}