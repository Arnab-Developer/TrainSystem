# Train System

A demo to show how to stop a train if door opens.

```mermaid
flowchart

Start --> IsAllDoorClosed
IsAllDoorClosed -- Yes --> TrainStart
IsAllDoorClosed -- No --> TrainDoNotStart
```