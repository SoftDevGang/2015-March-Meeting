using System;

namespace NUnit.Framework
{
	public class EmptyClass
	{
		// Issue: Inconsistent naming in the package Api. Things belong together, but sound like different things.
		// Navigation Smell: The class name is not revealing intent relative to its scope.
		// Issue: Interfaces and implementations are in the same place.
		// Navigation Smell: How do I know what are the interface I need to implement. Where do I find them?
		// Issue: Maybe adding settings in each bounded context makes navigation to the settings harder.
		// Question: Could it be that certain navigation smells appeared because some people wanted to navigate faster?
		// Question: Maybe some navigation needs contradict other good rules of design and coding (ie grouping by type, bounded contexts)?
		// Example: interfaces not created to avoid next click for finding implementation
		// Issue: Design Pattern and other special names (model, service, etc) could be misused and create very strong problems.
		// This is a very strong name problem. 
		// Idea: What if we would have an algorithm to identify if the names of the design patterns 
		// are correct with respect to the code written

	}
}

