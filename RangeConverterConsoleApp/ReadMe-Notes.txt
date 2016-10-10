Some notes about implementing the code:
-static classes vs instance classes/methods may need to be considered in the context of easier testing  
- have implemented the following provided the question did not give more specific guidelines,
  but further extraction and improvements can be made based on requirements 
  like re-usability,security,input validation etc.
- if re-usability is important then the mothods can be extracted into a library for sharing 
-these mothod are stateless thus they can be used in a singleton to improve on the constraints of 
  static classes and testing.
