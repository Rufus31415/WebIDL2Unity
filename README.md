# WebIDL2Unity

**WebIDL2Unity** is a prototype of a powerful tool designed to automatically convert JavaScript API specifications written in **WebIDL** format into **C# code for Unity**.

For example, it can take a web specification such as [WebXR](https://immersive-web.github.io/webxr/) and generate the corresponding Unity-compatible C# bindings, as shown in this repository: [WebXRDeviceAPI for Unity](https://github.com/Rufus31415/WebIDL2Unity/tree/main/Unity-Test/Assets/WebXR/WebXRDeviceAPI).

This project is not an empty shell — when you compile your Unity project and call the generated C# functions (which mirror the JavaScript APIs defined in the WebIDL), those calls are executed directly in JavaScript through the WebAssembly layer produced by Unity’s WebGL build.

WebIDL2Unity demonstrates how the gap between web-native APIs and Unity scripting can be bridged seamlessly, making it possible to integrate advanced browser APIs into Unity projects without manually writing glue code.

This is a concept and an open exploration. If you’re interested or motivated to collaborate, discussions and contributions are more than welcome!
