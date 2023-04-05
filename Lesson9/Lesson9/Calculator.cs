using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Lesson9
{
    internal class Calculator
    {
        public string Display { get; private set; }
        public string Memory => _memoryNumber == 0 ? "" : "M";

        private State _state;

        private double _firstNumber;
        private double _secondNumber;
        private double _memoryNumber;
        private OperationType _operationType;

        public Calculator()
        {
            Display = "0";
            _memoryNumber = 0;
        }

        public void Button(Button button)
        {
            string[] buttonInfo = button.Name.Split("_");

            switch (GetButtonType(buttonInfo[0]))
            {
                case ButtonType.Function:
                    HandleFunctionButton(buttonInfo[1]);
                    break;

                case ButtonType.Operation:
                    HandleOperationButton(buttonInfo[1]);
                    break;

                case ButtonType.Memory:
                    HandleMemoryButton(buttonInfo[1]);
                    break;

                default:
                    HandleNumberButton(button.Content.ToString());
                    break;
            }
        }

        private void HandleNumberButton(string digit)
        {
            if (_state == State.Result)
            {
                _state = State.FirstNumber;
                Display = "0";
            }
            
            Display = Display == "0" ? digit : Display += digit;
        }

        private void HandleOperationButton(string operation)
        {
            switch (operation)
            {
                case "PlusMinus":
                    if (Display == "0") return;
                    Display = Display[0] == '-' ? Display[1..] : "-" + Display;
                    return;

                case "Divide":
                    _operationType = OperationType.Divide;
                    break;
                
                case "Multiple":
                    _operationType = OperationType.Multiple;
                    break;
                
                case "Subtract":
                    _operationType = OperationType.Subtract;
                    break;
                
                case "Add":
                    _operationType = OperationType.Add;
                    break;
                
                case "DecimalPoint":
                    if (!Display.Contains(',') && _state != State.Result) Display += ",";
                    return;
                
                case "Equals":
                    HandleResult();
                    return;
            }
            
            SetNumber();
            _state = State.SecondNumber;
        }

        private void HandleFunctionButton(string function)
        {
            switch (function)
            {
                case "ClearEntry":
                    Display = "0";
                    break;
                
                case "Backspace":
                    if (_state == State.Result) return;
                    Display = Display.Length - 1 == 0 ? "0" : Display[..^1];
                    break;
                
                case "Clear":
                    _firstNumber = 0;
                    _secondNumber = 0;
                    Display = "0";
                    _state = State.FirstNumber;
                    break;
            }
        }

        private void HandleMemoryButton(string action)
        {
            switch (action)
            {
                case "Clear":
                    _memoryNumber = 0;
                    break;
                
                case "Recall":
                    Display = _memoryNumber.ToString();
                    break;
                
                case "Save":
                    _memoryNumber = double.Parse(Display);
                    Display = "0";
                    break;
                
                case "Subtract":
                    _memoryNumber -= double.Parse(Display);
                    Display = _memoryNumber.ToString();
                    _firstNumber = _memoryNumber;
                    break;
                
                case "Add":
                    _memoryNumber += double.Parse(Display);
                    Display = _memoryNumber.ToString();
                    _firstNumber = _memoryNumber;
                    break;
            }
        }

        private void HandleResult()
        {
            SetNumber();
            _state = State.Result;
            double result = 0;

            switch (_operationType)
            {
                case OperationType.Add:
                    result = _firstNumber + _secondNumber;
                    break;
                case OperationType.Subtract:
                    result = _firstNumber - _secondNumber;
                    break;
                case OperationType.Multiple:
                    result = _firstNumber * _secondNumber;
                    break;
                case OperationType.Divide:
                    result = _firstNumber / _secondNumber;
                    break;
            }

            Display = result.ToString();
            _firstNumber = result;
        }

        private void SetNumber()
        {
            switch (_state)
            {
                case State.FirstNumber:
                    _firstNumber = double.Parse(Display);
                    break;
                case State.SecondNumber:
                    _secondNumber = double.Parse(Display);
                    break;
            }

            Display = "0";
        }

        private ButtonType GetButtonType(string buttonType)
        {
            return buttonType switch
            {
                "Func" => ButtonType.Function,
                "Operation" => ButtonType.Operation,
                "Memory" => ButtonType.Memory,
                _ => ButtonType.Number
            };
        }
    }
}
