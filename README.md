RedLaser

This is a MonoTouch binding for the RedLaser Library which can be found at

 http://redlaser.com/sdk/index.php
 
 Building
 To build the bindings, open up Redlaser.iOS binding project in Xamarin Studio and build
 
 Using RedLaser.dll with your own iOS App
Simply add RedLaser.dll to your project's References in Xamarin Studio, add addional arguments --gcc_flags="-stdlib=libstdc++" for your project in options->build->additional monotouch argument you are good to go!
