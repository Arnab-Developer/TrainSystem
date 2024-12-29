# Train System

A demo to show how to stop a train if door opens.

```mermaid
flowchart

Start@{ shape: circle, label: "Start" }
Stop@{ shape: circle, label: "Stop" }

IsAllDoorClosed@{ shape: diamond, label: "Is all doors closed?" }
TrainStart@{ shape: rect, label: "Start the engine" }
TrainDoNotStart@{ shape: rect, label: "Do not start the engine" }
DoorOpen@{ shape: event, label: "Open a door" }
EmergencyBreak@{ shape: rect, label: "Activate emergency break" }
StopTrain@{ shape: rect, label: "Stop the engine" }

style DoorOpen fill:red, color: white

Start --> IsAllDoorClosed
IsAllDoorClosed -- Yes --> TrainStart
IsAllDoorClosed -- No --> TrainDoNotStart
TrainDoNotStart --> Stop

TrainStart --> DoorOpen
DoorOpen --> EmergencyBreak
EmergencyBreak --> StopTrain
StopTrain --> Stop
```