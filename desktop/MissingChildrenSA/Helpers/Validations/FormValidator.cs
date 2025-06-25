namespace MissingChildrenSA.Helpers.Validations;

public static class FormValidator
{
    public delegate bool ValidationRule(Control control);

    public static bool Validate(
        Control control,
        string fieldName,
        ValidationRule rule,
        string errorMessage = null,
        MessageBoxIcon messageBoxIcon = MessageBoxIcon.Warning)
    {
        if (!rule(control))
        {
            MessageBox.Show(errorMessage ?? $"{fieldName} is invalid.", "Validation Error", MessageBoxButtons.OK, messageBoxIcon);

            control.Focus();

            return false;
        }

        return true;
    }

    public static bool ValidateMultiple(params (Control control, string fieldName, ValidationRule rule, string errorMessage)[] validations)
    {
        foreach (var (control, fieldName, rule, message) in validations)
        {
            if (!Validate(control, fieldName, rule, message))
                return false;
        }
        return true;
    }
}