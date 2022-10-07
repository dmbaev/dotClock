namespace dotClock
{
    internal static class dots
    {
        static public char[][] get_dot(bool _dot)
        {
            switch (_dot)
            {
                case true:
                    return new char[][]{
                        new char[] { ' ',' ',' ',' ' },
                        new char[] { ' ','#','#',' ' },
                        new char[] { ' ','#','#',' ' },
                        new char[] { ' ',' ',' ',' ' },
                        new char[] { ' ',' ',' ',' ' },
                        new char[] { ' ',' ',' ',' ' },
                        new char[] { ' ',' ',' ',' ' },
                        new char[] { ' ','#','#',' ' },
                        new char[] { ' ','#','#',' ' },
                        new char[] { ' ',' ',' ',' ' },
                        };
                default:
                    return new char[][]{
                        new char[] { ' ',' ',' ',' ' },
                        new char[] { ' ',' ',' ',' ' },
                        new char[] { ' ',' ',' ',' ' },
                        new char[] { ' ',' ',' ',' ' },
                        new char[] { ' ',' ',' ',' ' },
                        new char[] { ' ',' ',' ',' ' },
                        new char[] { ' ',' ',' ',' ' },
                        new char[] { ' ',' ',' ',' ' },
                        new char[] { ' ',' ',' ',' ' },
                        new char[] { ' ',' ',' ',' ' },
                        };
            }
        }
    }
}
