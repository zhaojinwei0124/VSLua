//C:\Users\t-kevimi\\Documents\\LuaTests\Lua Files for Testing\MultipleTypeAssignment.lua\r\nusing LanguageModel.Tests.TestGeneration;
using LanguageService;
using LanguageModel.Tests.TestGeneration;
using Xunit;
namespace LanguageModel.Tests.GeneratedTestFiles
{
    class Generated_24
    {
        [Fact]
        public void Test(Tester t)
        {
            t.N(SyntaxKind.ChunkNode);
            {
                t.N(SyntaxKind.BlockNode);
                {
                    t.N(SyntaxKind.AssignmentStatementNode);
                    {
                        t.N(SyntaxKind.VarList);
                        {
                            t.N(SyntaxKind.NameVar);
                            {
                                t.N(SyntaxKind.Identifier);
                            }
                            t.N(SyntaxKind.Comma);
                            t.N(SyntaxKind.NameVar);
                            {
                                t.N(SyntaxKind.Identifier);
                            }
                            t.N(SyntaxKind.Comma);
                            t.N(SyntaxKind.NameVar);
                            {
                                t.N(SyntaxKind.Identifier);
                            }
                        }
                        t.N(SyntaxKind.AssignmentOperator);
                        t.N(SyntaxKind.ExpList);
                        {
                            t.N(SyntaxKind.SimpleExpression);
                            {
                                t.N(SyntaxKind.String);
                            }
                            t.N(SyntaxKind.Comma);
                            t.N(SyntaxKind.SimpleExpression);
                            {
                                t.N(SyntaxKind.Number);
                            }
                            t.N(SyntaxKind.Comma);
                            t.N(SyntaxKind.TableConstructorExp);
                            {
                                t.N(SyntaxKind.OpenCurlyBrace);
                                t.N(SyntaxKind.FieldList);
                                t.N(SyntaxKind.CloseCurlyBrace);
                            }
                        }
                    }
                }
                t.N(SyntaxKind.EndOfFile);
            }
        }
    }
}