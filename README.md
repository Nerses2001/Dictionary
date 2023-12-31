# Dictionary
## Description of the `Dictionary` Data Type in C# and Its Functionality

The `Dictionary` is one of the data structures in the C# programming language used to store data in key-value pairs. Each element in the `Dictionary` has a unique key through which you can access the corresponding value. This data type provides fast access to a value based on its key.

### Key Features and Working Principle

- **Key Uniqueness**: Each key in the `Dictionary` is unique. If you attempt to add a new item with an already existing key, it will overwrite the previous value.

- **Efficiency**: `Dictionary` ensures fast access to elements due to its internal implementation based on a hash table. This allows for efficient handling of large volumes of data.

- **Key-Value Pairs**: Elements are stored as key-value pairs, where each key corresponds to a specific value. This enables efficient retrieval of values based on the key.

### Complexity of Methods

- **Adding an Element (`Add`)**: O(1) - constant time on average. In some cases, it can be O(n) in the worst case due to rehashing.

- **Accessing an Element by Key (`Access by Key`)**: O(1) - constant time on average. In the worst case, it can also be O(n) due to rehashing.

- **Removing an Element (`Remove`)**: O(1) - constant time on average. In the worst case, it can also be O(n) due to rehashing.

These characteristics make `Dictionary` an efficient data structure for storing and accessing data by key.
