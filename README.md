# in-class-activities
## Devlogs
### W1
The camera will no longer be apart of the cat (like following the cat or in its perspective) because since it is no longer connected to that GameObject, it now has its own free will. 

### W2
1. They are floats because the color wheel is flexible like that. It is technically integers but this programming system prefers it to be decimals (float). 
2. It has to be a full number since it needs to completely touch the ground and not levitate above it (like 0.1 away from the ground).
3. The text said the line was incomplete because it didn't have a semicolon.

### W3
1.  Input - Player's choice / Output - character dialogue / Players options are determined by the parameters / Parameters - friendship level and if player knows characters secret
2. Input - characters insanity / no return types (void) 
3. Input - if they hit the key / Output - beat
4. class - spell book / component - tools like wand / member variable - the casters / method - actual spell 
5. I think the balls get brighter because the color gets multiplied by the method GetColorMultiplier, making the color of the ball skyrocket whenever it gets hit (the hex codes change).

### W4
1. We added the Rigidbodies to the cat and the ball and we put the IsTrigger in the goal. Rigidbodies to the cat and ball because they actually need to move while the goal doesn't. The IsTrigger for the goal is for the ball to trigger something when it hits the goal. 
2. The cat was dropping to the side or tilting whenever we hit the ball. The way we fixed this was freezing the position of rotation, specifically X and Z axes. 

### W5
Activity 1
Since the code is similar for the Cat and Deer script, we copy and paste the CatW5 code into the DeerW5. We also changed the class name from CatW5 to DeerW5.
The deer needs to move in its own direction and on its own, so we had it start at a certain point then move it towards a specific target. 
1. The member variables this class needs are the NavMeshAgent and Transform
2. The methods used are the Start(), Update(), and SetDestination: the start is to start the game, the update to update the movements every frame, and the SetDestination to point in the direction of a specific point.

### W7
Activity 1
https://docs.google.com/document/d/1ZtUXbaq48lSscmZFjwwkLhq-6Y2Undi4IIagxdTtJH4/edit?usp=sharing

Activity 2
1. The member variables the BatW6 has is the the speed of the bats.  
2. The methods this class needs EnableChase(), & DisableChase(), and the Update() Method. 
3. The EnableChase when enabled, the bats will follow the player and the Disable Chase when enabled, it will stop bats from moving. The Update method will update every frame when the enemy moves toward the player. 
