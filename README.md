# CardGame

- Cards build up from the draggable component.


### Draggable
This is the draggable component. Anything that is dragged is built off of the draggable component. Cards build off the draggable component. Public functions are used by the snapcontroller and snappoints.

- public void setSnapPoint(SnapPoint snapObject): Sets its current snap point to snappoint argument

### SnapPoint
This is a snappoint node. Used by snap controller to snap draggable objects. These are basically nodes that we can create to snap draggable objects.

- public bool containsDraggable(): Checks if snappoint contains a draggable object
- public void setDraggable(Draggable draggableObject): Sets its current draggable to draggable argument
- public Draggable getDraggable(): Returns current draggable


### Card
Contains properties of card scriptable object. 

- public getters and setters
