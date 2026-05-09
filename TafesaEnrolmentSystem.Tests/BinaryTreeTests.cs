using TafesaEnrolmentSystem.Model;

namespace TafesaEnrolmentSystem.Tests;

public class BinaryTreeTests
{
    private BinaryTree<Student> tree;

    [SetUp]
    public void Setup()
    {
        tree = new BinaryTree<Student>();
        tree.Add(new Student("400000"));
        tree.Add(new Student("200000"));
        tree.Add(new Student("600000"));
        tree.Add(new Student("100000"));
        tree.Add(new Student("300000"));
        tree.Add(new Student("500000"));
        tree.Add(new Student("700000"));
    }

    [Test]
    public void PreOrderTraversal_ReturnsCorrectOrder()
    {
        // create empty list to store traversal result:
        List<Student> results = new List<Student>();

        // traverse
        tree.TraversePreOrder(tree.Root, results);

        Assert.That(results[0].StudentID, Is.EqualTo("400000"));
        Assert.That(results[1].StudentID, Is.EqualTo("200000"));
        Assert.That(results[2].StudentID, Is.EqualTo("100000"));
        Assert.That(results[3].StudentID, Is.EqualTo("300000"));
        Assert.That(results[4].StudentID, Is.EqualTo("600000"));
        Assert.That(results[5].StudentID, Is.EqualTo("500000"));
        Assert.That(results[6].StudentID, Is.EqualTo("700000"));
    }

    [Test]
    public void PostOrderTraversal_ReturnsCorrectOrder()
    {
        // create empty list to store traversal result:
        List<Student> results = new List<Student>();

        // traverse
        tree.TraversePostOrder(tree.Root, results);

        Assert.That(results[0].StudentID, Is.EqualTo("100000"));
        Assert.That(results[1].StudentID, Is.EqualTo("300000"));
        Assert.That(results[2].StudentID, Is.EqualTo("200000"));
        Assert.That(results[3].StudentID, Is.EqualTo("500000"));
        Assert.That(results[4].StudentID, Is.EqualTo("700000"));
        Assert.That(results[5].StudentID, Is.EqualTo("600000"));
        Assert.That(results[6].StudentID, Is.EqualTo("400000"));
    }

    [Test]
    public void InOrderTraversal_ReturnsCorrectOrder()
    {
        // create empty list to store traversal result:
        List<Student> results = new List<Student>();

        // traverse
        tree.TraverseInOrder(tree.Root, results);

        Assert.That(results[0].StudentID, Is.EqualTo("100000"));
        Assert.That(results[1].StudentID, Is.EqualTo("200000"));
        Assert.That(results[2].StudentID, Is.EqualTo("300000"));
        Assert.That(results[3].StudentID, Is.EqualTo("400000"));
        Assert.That(results[4].StudentID, Is.EqualTo("500000"));
        Assert.That(results[5].StudentID, Is.EqualTo("600000"));
        Assert.That(results[6].StudentID, Is.EqualTo("700000"));
    }
}
