using AVL;

//AVLTree tree = new AVLTree();

AVLTree tree = new AVLTree();

tree.root = tree.InsertioTree(tree.root, 10);
tree.root = tree.InsertioTree(tree.root, 20);
tree.root = tree.InsertioTree(tree.root, 30);

tree.preOrder(tree.root);

///* The constructed AVL Tree would be
//	30
//	/ \
//20 40
/// \ \
//10 25 50
//*/