namespace AwesomeCollections
(* AwesomeCollections.fsi *)

type 'a stack =
  | EmptyStack
  | StackNode of 'a * 'a stack
  
module Stack = begin
  val hd : 'a stack -> 'a
  val tl : 'a stack -> 'a stack
  val cons : 'a -> 'a stack -> 'a stack
  val empty : 'a stack
  val rev : 'a stack -> 'a stack
end

