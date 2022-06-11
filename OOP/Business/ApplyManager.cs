using System.Collections.Generic;

namespace OOP
{
    public class ApplyManager
    {
        //Method Injection
        public void Apply(ILoanManager loanManager, ILoggerService loggerService)
        {
            loanManager.Calculate();
            loggerService.Log(); //hangi loglayıcı seçildiyse onu loglayacaktır
        }

        public void LoanPreInform(List<ILoanManager> loanList)
        {
            foreach (var loan in loanList)
            {
                loan.Calculate();
            }
        }


    }
}
