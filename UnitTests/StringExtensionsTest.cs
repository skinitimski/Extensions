using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

using NUnit.Framework;

using Atmosphere.Extensions;

namespace Atmosphere.UnitTests
{
    [TestFixture]
    public class ExtensionsTest
    {
        private struct WithAnyStringTestCase
        {
            public string Input { get; set; }

            public string[] Values { get; set; }

            public bool Expected { get; set; }
        }
        
        [Test]
        public void TestEqualsAnyString()
        {
            Assert.Throws<ArgumentNullException>(() => ((string)null).EqualsAny("any"));
            
            List<WithAnyStringTestCase> testCases = new List<WithAnyStringTestCase>
            {
                new WithAnyStringTestCase
                {
                    Input = "String",
                    Values = null,
                    Expected = false
                },
                new WithAnyStringTestCase
                {
                    Input = "String",
                    Values = new string[] { },
                    Expected = false
                },
                new WithAnyStringTestCase
                {
                    Input = "String",
                    Values = new string[] { "a", "b", "c" },
                    Expected = false
                },
                new WithAnyStringTestCase
                {
                    Input = "String",
                    Values = new string[] { "a", "String", "c" },
                    Expected = true
                },
            };
            
            foreach (WithAnyStringTestCase testCase in testCases)
            {
                bool expected = testCase.Expected;
                bool actual = testCase.Input.StartsWithAny(testCase.Values);
                
                Assert.AreEqual(expected, actual);
            }
        }
            
        [Test]
        public void TestStartsWithAnyString()
        {
            Assert.Throws<ArgumentNullException>(() => ((string)null).StartsWithAny("any"));
                
            List<WithAnyStringTestCase> testCases = new List<WithAnyStringTestCase>
                {
                    new WithAnyStringTestCase
                    {
                        Input = "String",
                        Values = null,
                        Expected = false
                    },
                    new WithAnyStringTestCase
                    {
                        Input = "String",
                        Values = new string[] { },
                        Expected = false
                    },
                    new WithAnyStringTestCase
                    {
                        Input = "String",
                        Values = new string[] { "a", "b", "c" },
                        Expected = false
                    },
                    new WithAnyStringTestCase
                    {
                        Input = "String",
                        Values = new string[] { "a", "S", "c" },
                        Expected = true
                    },
                };
                
            foreach (WithAnyStringTestCase testCase in testCases)
            {
                bool expected = testCase.Expected;
                bool actual = testCase.Input.StartsWithAny(testCase.Values);
                    
                Assert.AreEqual(expected, actual);
            }
        }
        
        [Test]
        public void TestEndsWithAnyString()
        {
            Assert.Throws<ArgumentNullException>(() => ((string)null).EndsWithAny("any"));

            List<WithAnyStringTestCase> testCases = new List<WithAnyStringTestCase>
            {
                new WithAnyStringTestCase
                {
                    Input = "String",
                    Values = null,
                    Expected = false
                },
                new WithAnyStringTestCase
                {
                    Input = "String",
                    Values = new string[] { },
                    Expected = false
                },
                new WithAnyStringTestCase
                {
                    Input = "String",
                    Values = new string[] { "a", "b", "c" },
                    Expected = false
                },
                new WithAnyStringTestCase
                {
                    Input = "String",
                    Values = new string[] { "a", "g", "c" },
                    Expected = true
                },
            };
            
            foreach (WithAnyStringTestCase testCase in testCases)
            {
                bool expected = testCase.Expected;
                bool actual = testCase.Input.EndsWithAny(testCase.Values);
                
                Assert.AreEqual(expected, actual);
            }
        }










        
        private struct WithAnyCharTestCase
        {
            public string Input { get; set; }

            public char[] Values { get; set; }

            public bool Expected { get; set; }
        }
        
        [Test]
        public void TestStartsWithAnyChar()
        {
            Assert.Throws<ArgumentNullException>(() => ((string)null).StartsWithAny('a'));

            List<WithAnyCharTestCase> testCases = new List<WithAnyCharTestCase>
            {
                new WithAnyCharTestCase
                {
                    Input = "String",
                    Values = null,
                    Expected = false
                },
                new WithAnyCharTestCase
                {
                    Input = "String",
                    Values = new char[] { },
                    Expected = false
                },
                new WithAnyCharTestCase
                {
                    Input = "String",
                    Values = new char[] { 'a', 'b', 'c' },
                    Expected = false
                },
                new WithAnyCharTestCase
                {
                    Input = "String",
                    Values = new char[] { 'a', 'S', 'c' },
                    Expected = true
                },
            };
            
            foreach (WithAnyCharTestCase testCase in testCases)
            {
                bool expected = testCase.Expected;
                bool actual = testCase.Input.StartsWithAny(testCase.Values);
                
                Assert.AreEqual(expected, actual);
            }
        }
        
        [Test]
        public void TestEndsWithAnyChar()
        {
            Assert.Throws<ArgumentNullException>(() => ((string)null).EndsWithAny('a'));

            List<WithAnyCharTestCase> testCases = new List<WithAnyCharTestCase>
            {
                new WithAnyCharTestCase
                {
                    Input = "String",
                    Values = null,
                    Expected = false
                },
                new WithAnyCharTestCase
                {
                    Input = "String",
                    Values = new char[] { },
                    Expected = false
                },
                new WithAnyCharTestCase
                {
                    Input = "String",
                    Values = new char[] { 'a', 'b', 'c' },
                    Expected = false
                },
                new WithAnyCharTestCase
                {
                    Input = "String",
                    Values = new char[] { 'a', 'g', 'c' },
                    Expected = true
                },
            };
            
            foreach (WithAnyCharTestCase testCase in testCases)
            {
                bool expected = testCase.Expected;
                bool actual = testCase.Input.EndsWithAny(testCase.Values);
                
                Assert.AreEqual(expected, actual);
            }
        }
    }
}

