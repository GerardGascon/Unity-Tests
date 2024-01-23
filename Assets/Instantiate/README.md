# Instantiate

Small test to see the order of execution during an object instantiation.

Awake, Start, OnEnable and a custom method are tested to see when they are called.

### Result

The order of execution is the following:

    Awake -> OnEnable -> CustomMethod -> Start