using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArmyYearGenerator
{
    public partial class HelpForm : Form
    {
        const string HELP_FOR_PROCEDURE = "\t\t Для генерации расписания следуйте строго данному руководству:"
            + "\n\n\t1) Во вкладке 'План' добавьте все проводимые мероприятия (Например, утренняя зарядка, боевая подготовка и т.д.) с помощью кнопки 'Добавить событие'; "
            + "После открытия специального окна заполните необходимые поля, поставьте флаг 'Боевая подготовка'(Только если это предмет боевой подготовки), "
            + "добавьте темы и занятия с указанием их длительности в часах, а также укажите контрольные темы и нажмите кнопку 'Применить'. Когда все события будут внесены - нажмите кнопку 'Готовность';"
            + "\n\n\t2) Во вкладке 'Шаблон недели' нажмите кнопку 'Создать шаблон'. В появившемся окне выберите название события, время и дни недели его проведения. После этого нажмите 'Добавить';"
            + "\n\n\t3) Во вкладке 'Особенные дни' нажмите 'Добавить контрольные дни'. В появившемся окне сформируйте заново день, как это происходит при создании шаблона недели. После добавления всех событий нажмите 'Принять';"
            + "\n\n\t3) После всех этапов проверьте, правильно ли указан период обучения и нажмите 'Сгенерировать расписание';"
            + "\n\n\tПримечание: Для того, чтобы перегенерировать готовое расписание необходимо указать дату, с которой нужно переформировать расписание (Дата начала периода обучения), " 
            + "перейти на вкладку 'Изменение готового расписания'. Затем нажать 'Загрузить готовое расписание'. После загрузки измените шаблон недели, добавьте дни контрольных занятий и нажмите 'Сгенерировать расписание'.";

        const string HELP_FOR_PLAN = "Помощь по заполнению плана";
        const string HELP_FOR_WEEK_TEMPLATE = "Помощь по заполнению типовой недели";
        const string HELP_FOR_SPEC_DAYS = "Помощь по указанию контрольных и праздничных дней";
        const string HELP_FOR_CHANGING_SHEDULE = "Помощь по изменению готового расписания";
        public HelpForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showHelp(listBox1.SelectedItem.ToString());
        }

        void showHelp(string stepName)
        {
            if (stepName == "Последовательность действий")
                richTextBox1.Text = HELP_FOR_PROCEDURE;
            if (stepName == "План")
                richTextBox1.Text = HELP_FOR_PLAN;
            if (stepName == "Шаблон недели")
                richTextBox1.Text = HELP_FOR_WEEK_TEMPLATE;
            if (stepName == "Особенные дни")
                richTextBox1.Text = HELP_FOR_SPEC_DAYS;
            if (stepName == "Изменение готового расписания")
                richTextBox1.Text = HELP_FOR_CHANGING_SHEDULE;
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            listBox1.SetSelected(0, true);
        }
    }
}
