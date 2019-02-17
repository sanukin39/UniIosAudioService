# UniIosAudioService
Unity iOS plugin JUST playing iOS system sound

## Description
Plugin to use ios system sound and vibration at Unity.

## Demo
This project has scene for checking all system sound(Assets/Example/Example.scene).

Note: The plugin do nothing at Unity Editor. Use iOS devices or simulator when you check the sound.

<img src="https://user-images.githubusercontent.com/6077255/52907810-729a7680-32ac-11e9-8245-0ff27f7db35b.png" width="320">

## Usage
1. Find system sound id you want to use at demo scene.
2. Send the id to the plugin in your project.

```csharp
int soundId = 1001;
UniIosAudioService.PlaySystemSound(soundId);
```

## Install
Use unitypackage at [releases page](https://github.com/sanukin39/UniIosAudioService/releases).

## Licence

[MIT](https://github.com/sanukin39/UniIosAudioService/blob/master/LICENSE)

## Author

[sanukin39](https://github.com/sanukin39)
