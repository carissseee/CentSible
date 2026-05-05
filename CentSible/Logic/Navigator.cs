using CentSible.Forms;
using System.Windows.Forms;

public static class Navigator
{
    public static HomeForm Home;
    public static GoalForm Goal;
    public static SummaryForm Summary;
    public static TransactionForm Transaction;
    public static PredictionForm Prediction;

    public static void SwitchTo(Form from, Form to)
    {
        to.Show();
        from.Hide();
    }

    public static void Logout(Form current)
    {
        Home = null;
        Goal = null;
        Summary = null;
        Transaction = null;
        Prediction = null;
        new LoginForms().Show();
        current.Close();
    }
}