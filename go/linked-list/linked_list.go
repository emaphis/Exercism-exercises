package linkedlist

// Define List and Node types here.
// Note: The tests expect Node type to include an exported field with name Value to pass.

// Node is a node, holding a value in a linked list.
type Node struct {
	prev  *Node
	next  *Node
	Value interface{} // exported
}

func NewNode(v interface{}) *Node {
	return &Node{
		Value: v,
		next:  nil,
		prev:  nil,
	}
}

// List is a doubly-linked list with a Head and Tail
type List struct {
	head *Node
	tail *Node
}

func NewList(args ...interface{}) *List {
	list := &List{} // empty list
	for _, node := range args {
		list.Push(node)
	}
	return list
}

func (n *Node) Next() *Node {
	return n.next
}

func (n *Node) Prev() *Node {
	return n.prev
}

func (l *List) Unshift(v interface{}) {
	node := &Node{Value: v}
	if l.head == nil {
		l.head = node
		l.tail = l.head
	} else {
		node.next = l.head
		l.head = node
		node.next.prev = node
	}
}

func (l *List) Push(v interface{}) {
	node := &Node{Value: v}
	if l.tail == nil {
		l.head = node
		l.tail = l.head
	} else {
		l.tail.next = node
		node.prev = l.tail
		l.tail = node
	}
}

func (l *List) Shift() (value interface{}, err error) {
	if l.head != nil && l.head == l.tail {
		value = l.head.Value
		l.head = nil
		l.tail = nil
		return
	} else {
		value = l.head.Value
		l.head = l.head.next
		l.head.prev = nil
		return
	}
}

func (l *List) Pop() (value interface{}, err error) {
	if l.tail != nil && l.head == l.tail {
		value = l.tail.Value
		l.head = nil
		l.tail = nil
		return
	} else {
		value = l.tail.Value
		l.tail = l.tail.prev
		l.tail.next = nil
		return
	}
}

func (l *List) Reverse() {
	node := l.head
	for node != nil {
		node.next, node.prev = node.prev, node.next // cute swap expression
		node = node.prev
	}
	l.head, l.tail = l.tail, l.head
}

func (l *List) First() *Node {
	return l.head
}

func (l *List) Last() *Node {
	return l.tail
}
