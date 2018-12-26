
# react-native-background-notification

## Getting started

`$ npm install react-native-background-notification --save`

### Mostly automatic installation

`$ react-native link react-native-background-notification`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-background-notification` and add `RNBackgroundNotification.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNBackgroundNotification.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNBackgroundNotificationPackage;` to the imports at the top of the file
  - Add `new RNBackgroundNotificationPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-background-notification'
  	project(':react-native-background-notification').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-background-notification/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-background-notification')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNBackgroundNotification.sln` in `node_modules/react-native-background-notification/windows/RNBackgroundNotification.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Background.Notification.RNBackgroundNotification;` to the usings at the top of the file
  - Add `new RNBackgroundNotificationPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNBackgroundNotification from 'react-native-background-notification';

// TODO: What to do with the module?
RNBackgroundNotification;
```
  