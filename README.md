# libsm64-unity-dev

This repo contains a Unity project that wraps the [libsm64-unity](https://github.com/libsm64/libsm64-unity) package so it can be easily worked on directly inside Unity without going through the package manager.

To get started:
- Clone this repository, and recursively clone submodules:
    ```
    git clone https://github.com/libsm64/libsm64-unity
    cd libsm64-unity
    git submodule update --init --recursive
    ```
- Open the project in Unity 2019.3.10
- Make sure you have a controller attached
- Open the test scene `Assets/pipescene.unity`
- Run the scene, run around.
- Start poking around to see how things are set up
