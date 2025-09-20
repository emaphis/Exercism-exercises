class CalculatorConundrum {
    public String calculate(int operand1, int operand2, String operation) {

        // Switch expression version
        int result =
            switch (operation) {
                case "+" -> operand1 + operand2;
                case "*" -> operand1 * operand2;
                case "/" -> {
                    var out = 0;
                    try {
                        out = operand1 / operand2;
                    } catch (ArithmeticException ex) {
                        throw new IllegalOperationException("Division by zero is not allowed", ex);
                    }
                    yield out;
                }
                case "" -> throw new IllegalArgumentException("Operation cannot be empty");
                case null -> throw new IllegalArgumentException("Operation cannot be null");
                default -> throw new IllegalOperationException("Operation '" + operation + "' does not exist");
            };

        return operand1 + " " + operation + " " + operand2 + " = " + result;
    }
}
