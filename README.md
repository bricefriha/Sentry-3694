### Description
This MAUI project was created to test the behaviour of Sentry' prerelease version 4.12.1-segv1 upon PR [#3694](https://github.com/getsentry/sentry-dotnet/pull/3694).
This PR fixes [#3461](https://github.com/getsentry/sentry-dotnet/issues/3461) issue in which logcat.log is not attached to unhandled events.

### Tests
1. Run the app
2. Press the button 5 times
3. Unhandled exception should be triggered

## Result 
The Logcat is properly attached to the event on Sentry.
![image](https://github.com/user-attachments/assets/27494609-98d1-4c33-9ed5-2ee47662de5f)



