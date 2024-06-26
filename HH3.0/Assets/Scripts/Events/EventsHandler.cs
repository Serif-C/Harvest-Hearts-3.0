using System;
using System.Collections.Generic;

public delegate void MovementDelegate(float inputX, float inputY, bool isWalking, bool isRunning, bool isIdle, bool isCarrying,
                                      ToolEffect toolEffect,
                                      bool isUsingToolRight, bool isUsingToolLeft, bool isUsingToolUp, bool isUsingToolDown,
                                      bool isLiftingToolRight, bool isLiftingToolLeft, bool isLiftingToolUp, bool isLiftingToolDown,
                                      bool isPickingRight, bool isPickingLeft, bool isPickingUp, bool isPickingDown,
                                      bool isSwingingToolRight, bool isSwingingToolLeft, bool isSwingingToolUp, bool isSwingingToolDown,
                                      bool isIdleRight, bool isIdleLeft, bool isIdleUp, bool isIdleDown);
public static class EventsHandler
{
    // Inventory Updated Event
    public static event Action<InventoryLocation, List<InventoryItem>> InventoryUpdatedEvent;
    public static void CallInventoryUpdatedEvent(InventoryLocation inventoryLocation, List<InventoryItem> inventoryList)
    {
        if (InventoryUpdatedEvent != null)
            InventoryUpdatedEvent(inventoryLocation, inventoryList);
    }

    // Movement Event

    public static event MovementDelegate MovementEvent;

    // Movement Event call for publishers

    public static void CallMovementEvent(float inputX, float inputY, bool isWalking, bool isRunning, bool isIdle, bool isCarrying,
                                        ToolEffect toolEffect,
                                        bool isUsingToolRight, bool isUsingToolLeft, bool isUsingToolUp, bool isUsingToolDown,
                                        bool isLiftingToolRight, bool isLiftingToolLeft, bool isLiftingToolUp, bool isLiftingToolDown,
                                        bool isPickingRight, bool isPickingLeft, bool isPickingUp, bool isPickingDown,
                                        bool isSwingingToolRight, bool isSwingingToolLeft, bool isSwingingToolUp, bool isSwingingToolDown,
                                        bool isIdleRight, bool isIdleLeft, bool isIdleUp, bool isIdleDown)
    {
        if(MovementEvent != null)
        {
            MovementEvent(inputX, inputY, isWalking, isRunning, isIdle, isCarrying, toolEffect
                        , isUsingToolRight, isUsingToolLeft, isUsingToolUp, isUsingToolDown
                        , isLiftingToolRight, isLiftingToolLeft, isLiftingToolUp, isLiftingToolDown
                        , isPickingRight, isPickingLeft, isPickingUp, isPickingDown
                        , isSwingingToolRight, isSwingingToolLeft, isSwingingToolUp, isSwingingToolDown
                        , isIdleRight, isIdleLeft, isIdleUp, isIdleDown);
        }
    }
}