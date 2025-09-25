## Surface AR app:
  I followed the Workshop Guide 1 tutorial with some minor changes. I replaced the quad with a Default Plane and moved the script directly into the AR Session Origin, so the TapHandler object was removed. Since I moved the script, I had to make some adjustments by adding a Start function with “raycastManager = GetComponent<ARRaycastManager>();” inside of it. I also wanted to only place only one sphere per touch, so I added “if (touch.phase == TouchPhase.Began)” inside the Update function.


  Steps:
  - Install all AR features
  - Change Build settings (Switch to Android, Use OpenGLES3, Use ARM64 and so on)
  - Add an AR Session and AR Session Origin, which includes AR Plane Manager, AR Raycast Manager.
  - Add an AR Camera as a child to AR Session Origin, which includes AR Camera Manager, AR Pose Driver, AR Camera Background
  - Create a Default Plane prefab and Sphere (including material)
  - Add the script (from Workshop Guide 1 + my own changes) to AR Session Origin
  - Check the AR Core and build the APK


  References:
  - Workshop Guide 1
  - https://docs.unity3d.com/6000.2/Documentation/ScriptReference/Component.GetComponent.html 
  - https://docs.unity3d.com/ScriptReference/TouchPhase.Began.html



## Marker AR app:


  I followed and used the Workshop Guide 2 tutorial with no changes of my own.

  Steps:
  - Install all AR features.
  - Change Build settings (Switch to Android, Use OpenGLES3, Use ARM64 and so on).
  - Add an AR Session and AR Session Origin, which includes AR Tracked Image Manager.
  - Add an AR Camera as a child to AR Session Origin, which includes AR Camera Manager, AR Pose Driver, AR Camera Background.
  - Create a Marker Library using the Hiro image.
  - Add the script (from Workshop Guide 2) that opens a Youtube video, and assign it to a prefab.
  - Check the AR Core and build the APK

