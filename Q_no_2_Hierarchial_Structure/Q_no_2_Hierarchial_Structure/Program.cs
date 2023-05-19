using System;
using System.Collections.Generic;

class Branch
{
    private List<Branch> branches;

    public Branch()
    {
        branches = new List<Branch>();
    }

    public void AddBranch(Branch branch)
    {
        branches.Add(branch);
    }

    public List<Branch> GetBranches()
    {
        return branches;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create the hierarchical structure
        Branch root = new Branch();
        Branch branch1 = new Branch();
        Branch branch2 = new Branch();
        Branch branch3 = new Branch();
        Branch branch4 = new Branch();
        Branch branch5 = new Branch();
        Branch branch6 = new Branch();
        Branch branch7 = new Branch();
        Branch branch8 = new Branch();
        Branch branch9 = new Branch();
        Branch branch10 = new Branch();
        Branch branch11 = new Branch();

        root.AddBranch(branch1);
        root.AddBranch(branch2);
        branch1.AddBranch(branch3);
        branch2.AddBranch(branch4);
        branch2.AddBranch(branch5);
        branch2.AddBranch(branch6);
        branch4.AddBranch(branch7);
        branch5.AddBranch(branch8);
        branch5.AddBranch(branch9);
        branch8.AddBranch(branch10);
        


        // Calculating the depth of the structure
        int depth = CalculateDepth(root);

        Console.WriteLine("The depth of the structure is: " + depth);
    }

    static int CalculateDepth(Branch node)
    {
        if (node.GetBranches().Count == 0)
        {
            return 1;
        }
        else
        {
            int maxChildDepth = 0;
            foreach (Branch child in node.GetBranches())
            {
                int childDepth = CalculateDepth(child);
                maxChildDepth = Math.Max(maxChildDepth, childDepth);
            }
            return 1 + maxChildDepth;
        }
    }
}