﻿using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace Calculator.Tests
{
    public class AlphabeticCollectionOrderer : ITestCollectionOrderer
    {
        public IEnumerable<ITestCollection> OrderTestCollections(IEnumerable<ITestCollection> testCollections)
        {
            //return testCollections;

            var collectionOrder = testCollections.OrderBy(testCollection => testCollection.DisplayName);

            return collectionOrder;
        }
    }
}
