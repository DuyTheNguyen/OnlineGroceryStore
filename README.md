# OnlineGroceryStore-DuyTheNguyen

## Assumption

User enters the product's amount and code (optional) for Sliced Ham, Yoghurt and Toilet Rolls respectively.

For example:   
10 SH3  
12 YT2  
43 TR  
***
### **Algorithm**
***

#### `FilterThePacksWithAmount` method from `Calculator` class

This method is going to return the list of pack types.

  
***A***. In order to get the list of pack types, the original pack types of a product will be iterated in reverse order (from lagre to small).  
**If** the amount is the divisor of the current pack types, then return the list of pack types.  
**Otherwise**, it is going to check whether the remainder (of the amount and the current pack types) and is the divisor of the next pack types.

If it still has remaining amount once finished iterating. Then, it removes the largest pack types and do exactly the same as in part ***A*** until the list is empty.

For example:

28 YT2 

List of pack types (LPT) (3 elements): [4, 10, 15]  
Amount: 28

Loop through LPT in reverse order   
*(1st Loop)* 28 % 15 = 7  
*(2nd Loop)* 7 % 10 = 7  
*(3rd Loop)* 7 % 4 = **3**

***Since there is still remaining amount which is 3, the largest pack types, which is 15 ,will be removed.***

New list of pack types (2 elements): [4, 10]  
Amount: 28

Loop through LPT in reverse order   
*(1st Loop)*  28 % 10 = 8  
*(2nd Loop)*  8 % 4 = **0** -> ***no amount left, return this list of pack types***  




***
### **Design Pattern**
***
Factory method

***
### **Class Diagram**
***
![Class Diagram!](/class.PNG "Class Diagram")
