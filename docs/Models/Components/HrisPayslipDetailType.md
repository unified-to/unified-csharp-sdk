# HrisPayslipDetailType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = HrisPayslipDetailType.EarningSalary;

// Open enum: use .Of() to create instances from custom string values
var custom = HrisPayslipDetailType.Of("custom_value");
```


## Values

| Name                              | Value                             |
| --------------------------------- | --------------------------------- |
| `EarningSalary`                   | EARNING_SALARY                    |
| `EarningOvertime`                 | EARNING_OVERTIME                  |
| `EarningTip`                      | EARNING_TIP                       |
| `EarningBonus`                    | EARNING_BONUS                     |
| `EarningCommission`               | EARNING_COMMISSION                |
| `EarningAdjustment`               | EARNING_ADJUSTMENT                |
| `Earning`                         | EARNING                           |
| `PretaxDeduction`                 | PRETAX_DEDUCTION                  |
| `PretaxDeductionHealthInsurance`  | PRETAX_DEDUCTION_HEALTH_INSURANCE |
| `PretaxDeductionRetirement`       | PRETAX_DEDUCTION_RETIREMENT       |
| `PretaxDeductionHra`              | PRETAX_DEDUCTION_HRA              |
| `TaxFederal`                      | TAX_FEDERAL                       |
| `TaxRegion`                       | TAX_REGION                        |
| `TaxLocal`                        | TAX_LOCAL                         |
| `PosttaxBenefit`                  | POSTTAX_BENEFIT                   |
| `PosttaxGarnishment`              | POSTTAX_GARNISHMENT               |
| `Reimbursement`                   | REIMBURSEMENT                     |
| `EarningRegular`                  | EARNING_REGULAR                   |
| `EarningDoubleOvertime`           | EARNING_DOUBLE_OVERTIME           |
| `EarningPto`                      | EARNING_PTO                       |
| `EarningSick`                     | EARNING_SICK                      |
| `EarningHoliday`                  | EARNING_HOLIDAY                   |
| `EarningSeverance`                | EARNING_SEVERANCE                 |
| `EarningReimbursement`            | EARNING_REIMBURSEMENT             |
| `TaxSocialSecurity`               | TAX_SOCIAL_SECURITY               |
| `TaxMedicare`                     | TAX_MEDICARE                      |
| `TaxUnemployment`                 | TAX_UNEMPLOYMENT                  |
| `TaxEmployer`                     | TAX_EMPLOYER                      |
| `PretaxDeductionHsa`              | PRETAX_DEDUCTION_HSA              |
| `PretaxDeductionFsa`              | PRETAX_DEDUCTION_FSA              |
| `PretaxDeductionDependentCare`    | PRETAX_DEDUCTION_DEPENDENT_CARE   |
| `PretaxDeductionCommuter`         | PRETAX_DEDUCTION_COMMUTER         |
| `PretaxDeductionDental`           | PRETAX_DEDUCTION_DENTAL           |
| `PretaxDeductionVision`           | PRETAX_DEDUCTION_VISION           |
| `PosttaxDeduction`                | POSTTAX_DEDUCTION                 |
| `PosttaxRetirementRoth`           | POSTTAX_RETIREMENT_ROTH           |
| `PosttaxLoanRepayment`            | POSTTAX_LOAN_REPAYMENT            |
| `EmployerContribution`            | EMPLOYER_CONTRIBUTION             |
| `Pension`                         | PENSION                           |
| `EarningCashInLieu`               | EARNING_CASH_IN_LIEU              |