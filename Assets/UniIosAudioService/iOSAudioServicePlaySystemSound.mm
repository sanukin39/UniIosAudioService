#import <Foundation/Foundation.h>
#import <AudioToolBox/AudioToolBox.h>

extern "C" void audioServicePlaySystemSound (int soundId)
{
    AudioServicesPlaySystemSound(soundId);
}
