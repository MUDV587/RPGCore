# RPGCore

[![Build Status](https://github.com/Fydar/RPGCore/workflows/Build/badge.svg)](https://github.com/Fydar/RPGCore/actions?query=workflow%3ABuild)
[![Unit Test Status](https://github.com/Fydar/RPGCore/workflows/Unit%20Tests/badge.svg)](https://github.com/Fydar/RPGCore/actions?query=workflow%3A%22Unit+Tests%22)

RPGCore is a toolkit for producing RPG games and mechanics in C#.

![Rewrite Editor](./docs/img/rpgcore_social.png)

## The "Rewrite"

[![Unity Version: 2019.3.0f6](https://img.shields.io/badge/Unity-2019.3.0f6-333333.svg?logo=unity)](https://unity3d.com/get-unity/download/archive) [![Status: Work-in-progress](https://img.shields.io/badge/status-work--in--progress-orange)](https://github.com/Fydar/RPGCore/projects/1)

The "Rewrite" project delivers the following features:

- A **high-performance** and extensible node-based **behaviour system**
- Unity-independent code-base that can run on servers
- Intuitive **API for creating custom nodes**

![Rewrite Editor](./docs/img/wip-editor.png)

## The "Prototype"

[![Unity Version: 2018.2.3f1](https://img.shields.io/badge/Unity-2018.2.3f1-333333.svg?logo=unity)](https://unity3d.com/get-unity/download/archive) ![Status: Work-in-progress](https://img.shields.io/badge/status-released-brightgreen)

> "Many screenshots of RPGCore are from the "Prototype" project. I don't recommend anyone use this project commercially unless they understand it and are willing to modify it to suit their needs. This code has no multiplayer compatibility (yet) and uses a lot of lambda expressions to accomplish the node connections."

![RPGCore Main Demo](./docs/screenshots/Main.png)

At it's core, this project features a behaviour system that's used to create modular items and buffs. The behaviour system is setup using a visual scripting tool, shown below.

RPGCore is built around a modular behaviour system. One of the core uses for this system is **modular items**.

Below is an item called the "Fire Cape". It applies the Immolate buff to it's owner, which deals damage to nearby enemies.

![Fire Cape Graph](./docs/screenshots/FireCapeGraph.png)

This graph in the game is interpreted by the tooltip system, which renders the "Fire Cape" tooltip as shown below.

![Fire Cape Tooltip](./docs/screenshots/FireCapeTooltip.png)

## License

[![License](https://img.shields.io/github/license/Fydar/RPGCore)](https://github.com/Fydar/RPGCore/blob/master/LICENSE)

This work is licensed under the Apache License, Version 2.0, meaning you are free to use this work commercially under the conditions the LICENSE and NOTICE file is included within the source.
