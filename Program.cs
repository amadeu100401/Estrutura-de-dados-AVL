using AVL;

AVLTree tree = new AVLTree();

//tree.root = tree.InsertionTree(tree.root, 10);
//tree.root = tree.InsertionTree(tree.root, 20);
//tree.root = tree.InsertionTree(tree.root, 30);
//tree.root = tree.InsertionTree(tree.root, 40);
//tree.root = tree.InsertionTree(tree.root, 50);
//tree.root = tree.InsertionTree(tree.root, 25);
//tree.root = tree.InsertionTree(tree.root, 26);
//tree.root = tree.InsertionTree(tree.root, 27);
//tree.root = tree.InsertionTree(tree.root, 28);

tree.root = tree.InsertionNode(tree.root, 130);
tree.root = tree.InsertionNode(tree.root, 120);
tree.root = tree.InsertionNode(tree.root, 110);
tree.root = tree.InsertionNode(tree.root, 100);
tree.root = tree.InsertionNode(tree.root, 90);
tree.root = tree.InsertionNode(tree.root, 80);
tree.root = tree.InsertionNode(tree.root, 70);


tree.ShowUpTree(tree.root);