using Antlr4.Runtime.Tree;
using Antlr4.Runtime;
using Antlr4VS.Antlr;
using System.Text.RegularExpressions;

namespace University.CSharpLexerParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeLexerParserUI();
            Act();
        }

        private void InitializeLexerParserUI()
        {
            // Таблица токенов
            dataGridViewTokens.Columns.Add("Line", "Строка");
            dataGridViewTokens.Columns.Add("Column", "Колонка");
            dataGridViewTokens.Columns.Add("Type", "Тип");
            dataGridViewTokens.Columns.Add("Value", "Значение");
        }

        private void AddToken(int line, int column, string type, string value)
        {
            dataGridViewTokens.Rows.Add(line, column, type, value);
        }

        private void Act()
        {
            string file = "example.cs";
            string input = File.ReadAllText(file);
            textBoxCode.Text = input;

            ICharStream inputStream = CharStreams.fromString(input);
            CSharpLexer lexer = new(inputStream);
            CommonTokenStream commonTokenStream = new CommonTokenStream(lexer);
            CSharpParser parser = new(commonTokenStream);

            //parser.RemoveErrorListeners();
            var errorListener = new SyntaxErrorListener();
            parser.RemoveErrorListeners();
            parser.AddErrorListener(errorListener);

            CSharpParser.Compilation_unitContext tree = parser.compilation_unit(); // Исправлено

            ICSharpParserVisitor<string> visitor = new CSharpParserBaseVisitor<string>();

            var tokens = new List<object>();
            for (int i = 0; i < commonTokenStream.Size; i++)
            {
                var token = commonTokenStream.Get(i);
                if (parser.Vocabulary.GetSymbolicName(token.Type) != "WS")
                {
                    AddToken(token.Line, token.Column, parser.Vocabulary.GetSymbolicName(token.Type), Regex.Replace(token.Text, @"\s+", ""));
                    tokens.Add(new
                    {
                        Index = i,
                        TokenType = parser.Vocabulary.GetSymbolicName(token.Type),
                        Value = token.Text,
                        Position = $"Line {token.Line}, Column {token.Column}"
                    });
                }
            }

            if (errorListener.Errors.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                //var treeNode = ConvertParseTreeToTreeNode(tree, parser);
                foreach (var err in errorListener.Errors)
                {
                    Console.WriteLine(err);
                }
                Console.ResetColor();
            }
            else
            {
                DisplayParseTree(tree);
                //var treeNode = ConvertParseTreeToTreeNode(tree, parser);
                //RenderTree(treeNode);
                treeViewAST.ExpandAll();
            }

            //var treeNode = ConvertParseTreeToTreeNode(tree, parser);

            //ICSharpParserListener listener = new Listener();
            ////ParseTreeWalker walker = new ParseTreeWalker();
            ////walker.Walk(listener, tree);
            //RenderTree(treeNode);
        }

        public void DisplayParseTree(IParseTree parseTree)
        {
            treeViewAST.Nodes.Clear(); // Очистка перед добавлением нового дерева
            TreeNode rootNode = ConvertParseTreeToTreeNode(parseTree);
            treeViewAST.Nodes.Add(rootNode);
            treeViewAST.ExpandAll();
        }

        private TreeNode ConvertParseTreeToTreeNode(IParseTree parseTree)
        {
            // Создаём узел для текущего элемента дерева
            TreeNode node = new TreeNode(parseTree.GetType().Name.Replace("Context", ""));

            // Если у узла есть текст, добавляем его
            if (parseTree.ChildCount == 0)
            {
                node.Text += $" : \"{parseTree.GetText()}\"";
            }

            // Рекурсивно обрабатываем всех детей
            for (int i = 0; i < parseTree.ChildCount; i++)
            {
                node.Nodes.Add(ConvertParseTreeToTreeNode(parseTree.GetChild(i)));
            }

            return node;
        }

        //private void RenderTree(TreeNode node, string indent = "", bool isLast = true)
        //{
        //    treeViewAST.Nodes.Add(node.Text);


        //    for (int i = 0; i < node.Children.Count; i++)
        //    {
        //        treeViewAST.Nodes.
        //        RenderTree(node.Children[i], indent, i == node.Children.Count - 1);
        //    }
        //}

        //public class TreeNode
        //{
        //    public TreeNode(string text)
        //    {
        //        Text = text;
        //    }
        //    public string Text { get; set; }
        //    public List<TreeNode> Children { get; set; } = new List<TreeNode>();
        //}

        //public static TreeNode ConvertParseTreeToTreeNode(IParseTree parseTree, CSharpParser parser)
        //{
        //    if (parseTree == null)
        //    {
        //        return new TreeNode { Text = "null" };
        //    }

        //    try
        //    {
        //        string nodeText;

        //        if (parseTree is ITerminalNode terminalNode)
        //        {
        //            string tokenText = terminalNode.Symbol.Text;
        //            tokenText = Regex.Replace(tokenText, "\"", "\\\"");
        //            nodeText = tokenText;
        //        }
        //        else
        //        {
        //            int ruleIndex = parseTree switch
        //            {
        //                IRuleNode ruleNode => ruleNode.RuleContext.RuleIndex,
        //                _ => 0
        //            };
        //            nodeText = parser.RuleNames[ruleIndex];
        //        }

        //        var node = new TreeNode { Text = nodeText };

        //        for (int i = 0; i < parseTree.ChildCount; i++)
        //        {
        //            node.Children.Add(ConvertParseTreeToTreeNode(parseTree.GetChild(i), parser));
        //        }

        //        return node;
        //    }
        //    catch (Exception ex)
        //    {
        //        return new TreeNode { Text = $"Error: {ex.Message}" };
        //    }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void codeTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
