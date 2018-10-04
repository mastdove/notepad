namespace блокнот
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОФайлеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.колвоСимволовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.колвоАвторскихСтраницToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.колвоГластныхБуквToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.колвоСогласныхБуквToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.колвоЦиферToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.колвоСпециальныхСимволовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.колвоЗнаковПунктуацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.колвоКиррилическихСимволовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.колвоЛаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.колвоПустыхСтрокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.колвоАбзацевToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.полнаяСтатистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.доподнительныеВозможностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пороверкаНаНаличаеКлючевыхСловСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаНаличаяАдрессаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаНаличияИнтернетадресовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаНаНаличиеКонстантToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.целочисленныеКонстантыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вещественныеКонстантыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.комплексныеКонстантыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискВсехЭлектронныхАдресовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискаПервогоВхожденияДвухСловимяИФамилияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискаПервогоВхождениеФамилииСИнициаламиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматированиеТекстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеВсехНезначущихПробеловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.информацияОФайлеToolStripMenuItem,
            this.доподнительныеВозможностиToolStripMenuItem,
            this.форматированиеТекстаToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // информацияОФайлеToolStripMenuItem
            // 
            this.информацияОФайлеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размерФайлаToolStripMenuItem,
            this.колвоСимволовToolStripMenuItem,
            this.колвоАвторскихСтраницToolStripMenuItem,
            this.колвоГластныхБуквToolStripMenuItem,
            this.колвоСогласныхБуквToolStripMenuItem,
            this.колвоЦиферToolStripMenuItem,
            this.колвоСпециальныхСимволовToolStripMenuItem,
            this.колвоЗнаковПунктуацииToolStripMenuItem,
            this.колвоКиррилическихСимволовToolStripMenuItem,
            this.колвоЛаToolStripMenuItem,
            this.колвоПустыхСтрокToolStripMenuItem,
            this.колвоАбзацевToolStripMenuItem,
            this.полнаяСтатистикаToolStripMenuItem});
            this.информацияОФайлеToolStripMenuItem.Name = "информацияОФайлеToolStripMenuItem";
            this.информацияОФайлеToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.информацияОФайлеToolStripMenuItem.Text = "Информация о файле";
            // 
            // размерФайлаToolStripMenuItem
            // 
            this.размерФайлаToolStripMenuItem.Name = "размерФайлаToolStripMenuItem";
            this.размерФайлаToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.размерФайлаToolStripMenuItem.Text = "Размер файла в байтах";
            this.размерФайлаToolStripMenuItem.Click += new System.EventHandler(this.размерФайлаToolStripMenuItem_Click);
            // 
            // колвоСимволовToolStripMenuItem
            // 
            this.колвоСимволовToolStripMenuItem.Name = "колвоСимволовToolStripMenuItem";
            this.колвоСимволовToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.колвоСимволовToolStripMenuItem.Text = "Кол-во символов";
            this.колвоСимволовToolStripMenuItem.Click += new System.EventHandler(this.колвоСимволовToolStripMenuItem_Click);
            // 
            // колвоАвторскихСтраницToolStripMenuItem
            // 
            this.колвоАвторскихСтраницToolStripMenuItem.Name = "колвоАвторскихСтраницToolStripMenuItem";
            this.колвоАвторскихСтраницToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.колвоАвторскихСтраницToolStripMenuItem.Text = "Кол-во авторских страниц";
            this.колвоАвторскихСтраницToolStripMenuItem.Click += new System.EventHandler(this.колвоАвторскихСтраницToolStripMenuItem_Click);
            // 
            // колвоГластныхБуквToolStripMenuItem
            // 
            this.колвоГластныхБуквToolStripMenuItem.Name = "колвоГластныхБуквToolStripMenuItem";
            this.колвоГластныхБуквToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.колвоГластныхБуквToolStripMenuItem.Text = "Кол-во гласных букв";
            this.колвоГластныхБуквToolStripMenuItem.Click += new System.EventHandler(this.колвоГластныхБуквToolStripMenuItem_Click);
            // 
            // колвоСогласныхБуквToolStripMenuItem
            // 
            this.колвоСогласныхБуквToolStripMenuItem.Name = "колвоСогласныхБуквToolStripMenuItem";
            this.колвоСогласныхБуквToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.колвоСогласныхБуквToolStripMenuItem.Text = "Кол-во согласных букв";
            this.колвоСогласныхБуквToolStripMenuItem.Click += new System.EventHandler(this.колвоСогласныхБуквToolStripMenuItem_Click);
            // 
            // колвоЦиферToolStripMenuItem
            // 
            this.колвоЦиферToolStripMenuItem.Name = "колвоЦиферToolStripMenuItem";
            this.колвоЦиферToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.колвоЦиферToolStripMenuItem.Text = "Кол-во цифер";
            this.колвоЦиферToolStripMenuItem.Click += new System.EventHandler(this.колвоЦиферToolStripMenuItem_Click);
            // 
            // колвоСпециальныхСимволовToolStripMenuItem
            // 
            this.колвоСпециальныхСимволовToolStripMenuItem.Name = "колвоСпециальныхСимволовToolStripMenuItem";
            this.колвоСпециальныхСимволовToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.колвоСпециальныхСимволовToolStripMenuItem.Text = "Кол-во Специальных символов";
            this.колвоСпециальныхСимволовToolStripMenuItem.Click += new System.EventHandler(this.колвоСпециальныхСимволовToolStripMenuItem_Click);
            // 
            // колвоЗнаковПунктуацииToolStripMenuItem
            // 
            this.колвоЗнаковПунктуацииToolStripMenuItem.Name = "колвоЗнаковПунктуацииToolStripMenuItem";
            this.колвоЗнаковПунктуацииToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.колвоЗнаковПунктуацииToolStripMenuItem.Text = "Кол-во знаков пунктуации";
            this.колвоЗнаковПунктуацииToolStripMenuItem.Click += new System.EventHandler(this.колвоЗнаковПунктуацииToolStripMenuItem_Click);
            // 
            // колвоКиррилическихСимволовToolStripMenuItem
            // 
            this.колвоКиррилическихСимволовToolStripMenuItem.Name = "колвоКиррилическихСимволовToolStripMenuItem";
            this.колвоКиррилическихСимволовToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.колвоКиррилическихСимволовToolStripMenuItem.Text = "Кол-во киррилических символов";
            this.колвоКиррилическихСимволовToolStripMenuItem.Click += new System.EventHandler(this.колвоКиррилическихСимволовToolStripMenuItem_Click);
            // 
            // колвоЛаToolStripMenuItem
            // 
            this.колвоЛаToolStripMenuItem.Name = "колвоЛаToolStripMenuItem";
            this.колвоЛаToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.колвоЛаToolStripMenuItem.Text = "Кол-во латинских букв";
            this.колвоЛаToolStripMenuItem.Click += new System.EventHandler(this.колвоЛаToolStripMenuItem_Click);
            // 
            // колвоПустыхСтрокToolStripMenuItem
            // 
            this.колвоПустыхСтрокToolStripMenuItem.Name = "колвоПустыхСтрокToolStripMenuItem";
            this.колвоПустыхСтрокToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.колвоПустыхСтрокToolStripMenuItem.Text = "Кол-во пустых строк";
            this.колвоПустыхСтрокToolStripMenuItem.Click += new System.EventHandler(this.колвоПустыхСтрокToolStripMenuItem_Click);
            // 
            // колвоАбзацевToolStripMenuItem
            // 
            this.колвоАбзацевToolStripMenuItem.Name = "колвоАбзацевToolStripMenuItem";
            this.колвоАбзацевToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.колвоАбзацевToolStripMenuItem.Text = "Кол-во абзацев";
            this.колвоАбзацевToolStripMenuItem.Click += new System.EventHandler(this.колвоАбзацевToolStripMenuItem_Click);
            // 
            // полнаяСтатистикаToolStripMenuItem
            // 
            this.полнаяСтатистикаToolStripMenuItem.Name = "полнаяСтатистикаToolStripMenuItem";
            this.полнаяСтатистикаToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.полнаяСтатистикаToolStripMenuItem.Text = "Полная статистика";
            this.полнаяСтатистикаToolStripMenuItem.Click += new System.EventHandler(this.полнаяСтатистикаToolStripMenuItem_Click);
            // 
            // доподнительныеВозможностиToolStripMenuItem
            // 
            this.доподнительныеВозможностиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пороверкаНаНаличаеКлючевыхСловСToolStripMenuItem,
            this.проверкаНаличаяАдрессаToolStripMenuItem,
            this.проверкаНаличияИнтернетадресовToolStripMenuItem,
            this.проверкаНаНаличиеКонстантToolStripMenuItem,
            this.поискВсехЭлектронныхАдресовToolStripMenuItem,
            this.поискаПервогоВхожденияДвухСловимяИФамилияToolStripMenuItem,
            this.поискаПервогоВхождениеФамилииСИнициаламиToolStripMenuItem});
            this.доподнительныеВозможностиToolStripMenuItem.Name = "доподнительныеВозможностиToolStripMenuItem";
            this.доподнительныеВозможностиToolStripMenuItem.Size = new System.Drawing.Size(193, 20);
            this.доподнительныеВозможностиToolStripMenuItem.Text = "Дополнительные возможности";
            this.доподнительныеВозможностиToolStripMenuItem.Click += new System.EventHandler(this.доподнительныеВозможностиToolStripMenuItem_Click);
            // 
            // пороверкаНаНаличаеКлючевыхСловСToolStripMenuItem
            // 
            this.пороверкаНаНаличаеКлючевыхСловСToolStripMenuItem.Name = "пороверкаНаНаличаеКлючевыхСловСToolStripMenuItem";
            this.пороверкаНаНаличаеКлючевыхСловСToolStripMenuItem.Size = new System.Drawing.Size(374, 22);
            this.пороверкаНаНаличаеКлючевыхСловСToolStripMenuItem.Text = "Пороверка на наличае ключевых слов С#";
            this.пороверкаНаНаличаеКлючевыхСловСToolStripMenuItem.Click += new System.EventHandler(this.пороверкаНаНаличаеКлючевыхСловСToolStripMenuItem_Click);
            // 
            // проверкаНаличаяАдрессаToolStripMenuItem
            // 
            this.проверкаНаличаяАдрессаToolStripMenuItem.Name = "проверкаНаличаяАдрессаToolStripMenuItem";
            this.проверкаНаличаяАдрессаToolStripMenuItem.Size = new System.Drawing.Size(374, 22);
            this.проверкаНаличаяАдрессаToolStripMenuItem.Text = "Проверка наличия  почтового адресса";
            this.проверкаНаличаяАдрессаToolStripMenuItem.Click += new System.EventHandler(this.проверкаНаличаяАдрессаToolStripMenuItem_Click);
            // 
            // проверкаНаличияИнтернетадресовToolStripMenuItem
            // 
            this.проверкаНаличияИнтернетадресовToolStripMenuItem.Name = "проверкаНаличияИнтернетадресовToolStripMenuItem";
            this.проверкаНаличияИнтернетадресовToolStripMenuItem.Size = new System.Drawing.Size(374, 22);
            this.проверкаНаличияИнтернетадресовToolStripMenuItem.Text = "Проверка наличия интернет-адресов";
            this.проверкаНаличияИнтернетадресовToolStripMenuItem.Click += new System.EventHandler(this.проверкаНаличияИнтернетадресовToolStripMenuItem_Click);
            // 
            // проверкаНаНаличиеКонстантToolStripMenuItem
            // 
            this.проверкаНаНаличиеКонстантToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.целочисленныеКонстантыToolStripMenuItem,
            this.вещественныеКонстантыToolStripMenuItem,
            this.комплексныеКонстантыToolStripMenuItem});
            this.проверкаНаНаличиеКонстантToolStripMenuItem.Name = "проверкаНаНаличиеКонстантToolStripMenuItem";
            this.проверкаНаНаличиеКонстантToolStripMenuItem.Size = new System.Drawing.Size(374, 22);
            this.проверкаНаНаличиеКонстантToolStripMenuItem.Text = "Проверка на наличие констант";
            // 
            // целочисленныеКонстантыToolStripMenuItem
            // 
            this.целочисленныеКонстантыToolStripMenuItem.Name = "целочисленныеКонстантыToolStripMenuItem";
            this.целочисленныеКонстантыToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.целочисленныеКонстантыToolStripMenuItem.Text = "Целочисленные константы";
            this.целочисленныеКонстантыToolStripMenuItem.Click += new System.EventHandler(this.целочисленныеКонстантыToolStripMenuItem_Click);
            // 
            // вещественныеКонстантыToolStripMenuItem
            // 
            this.вещественныеКонстантыToolStripMenuItem.Name = "вещественныеКонстантыToolStripMenuItem";
            this.вещественныеКонстантыToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.вещественныеКонстантыToolStripMenuItem.Text = "Вещественные константы";
            this.вещественныеКонстантыToolStripMenuItem.Click += new System.EventHandler(this.вещественныеКонстантыToolStripMenuItem_Click);
            // 
            // комплексныеКонстантыToolStripMenuItem
            // 
            this.комплексныеКонстантыToolStripMenuItem.Name = "комплексныеКонстантыToolStripMenuItem";
            this.комплексныеКонстантыToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.комплексныеКонстантыToolStripMenuItem.Text = "Комплексные константы";
            this.комплексныеКонстантыToolStripMenuItem.Click += new System.EventHandler(this.комплексныеКонстантыToolStripMenuItem_Click);
            // 
            // поискВсехЭлектронныхАдресовToolStripMenuItem
            // 
            this.поискВсехЭлектронныхАдресовToolStripMenuItem.Name = "поискВсехЭлектронныхАдресовToolStripMenuItem";
            this.поискВсехЭлектронныхАдресовToolStripMenuItem.Size = new System.Drawing.Size(374, 22);
            this.поискВсехЭлектронныхАдресовToolStripMenuItem.Text = "Проверка на наличие электронных адресов";
            this.поискВсехЭлектронныхАдресовToolStripMenuItem.Click += new System.EventHandler(this.поискВсехЭлектронныхАдресовToolStripMenuItem_Click);
            // 
            // поискаПервогоВхожденияДвухСловимяИФамилияToolStripMenuItem
            // 
            this.поискаПервогоВхожденияДвухСловимяИФамилияToolStripMenuItem.Name = "поискаПервогоВхожденияДвухСловимяИФамилияToolStripMenuItem";
            this.поискаПервогоВхожденияДвухСловимяИФамилияToolStripMenuItem.Size = new System.Drawing.Size(374, 22);
            this.поискаПервогоВхожденияДвухСловимяИФамилияToolStripMenuItem.Text = "Поиск первого вхождения двух слов (имя и фамилия).";
            this.поискаПервогоВхожденияДвухСловимяИФамилияToolStripMenuItem.Click += new System.EventHandler(this.поискаПервогоВхожденияДвухСловимяИФамилияToolStripMenuItem_Click);
            // 
            // поискаПервогоВхождениеФамилииСИнициаламиToolStripMenuItem
            // 
            this.поискаПервогоВхождениеФамилииСИнициаламиToolStripMenuItem.Name = "поискаПервогоВхождениеФамилииСИнициаламиToolStripMenuItem";
            this.поискаПервогоВхождениеФамилииСИнициаламиToolStripMenuItem.Size = new System.Drawing.Size(374, 22);
            this.поискаПервогоВхождениеФамилииСИнициаламиToolStripMenuItem.Text = "Поиск первого вхождение фамилии с инициалами";
            this.поискаПервогоВхождениеФамилииСИнициаламиToolStripMenuItem.Click += new System.EventHandler(this.поискаПервогоВхождениеФамилииСИнициаламиToolStripMenuItem_Click);
            // 
            // форматированиеТекстаToolStripMenuItem
            // 
            this.форматированиеТекстаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалениеВсехНезначущихПробеловToolStripMenuItem});
            this.форматированиеТекстаToolStripMenuItem.Name = "форматированиеТекстаToolStripMenuItem";
            this.форматированиеТекстаToolStripMenuItem.Size = new System.Drawing.Size(152, 20);
            this.форматированиеТекстаToolStripMenuItem.Text = "Форматирование текста";
            // 
            // удалениеВсехНезначущихПробеловToolStripMenuItem
            // 
            this.удалениеВсехНезначущихПробеловToolStripMenuItem.Name = "удалениеВсехНезначущихПробеловToolStripMenuItem";
            this.удалениеВсехНезначущихПробеловToolStripMenuItem.Size = new System.Drawing.Size(340, 22);
            this.удалениеВсехНезначущихПробеловToolStripMenuItem.Text = "Удаление всех незначущих символов и их групп";
            this.удалениеВсехНезначущихПробеловToolStripMenuItem.Click += new System.EventHandler(this.удалениеВсехНезначущихПробеловToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(657, 426);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Блокнот";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem информацияОФайлеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерФайлаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem колвоСимволовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem колвоАвторскихСтраницToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem колвоГластныхБуквToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem колвоСогласныхБуквToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem колвоЦиферToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem колвоСпециальныхСимволовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem колвоЗнаковПунктуацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem колвоКиррилическихСимволовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem колвоЛаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem колвоПустыхСтрокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem колвоАбзацевToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматированиеТекстаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалениеВсехНезначущихПробеловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem доподнительныеВозможностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пороверкаНаНаличаеКлючевыхСловСToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверкаНаличаяАдрессаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверкаНаличияИнтернетадресовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверкаНаНаличиеКонстантToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem целочисленныеКонстантыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вещественныеКонстантыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem комплексныеКонстантыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискВсехЭлектронныхАдресовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem полнаяСтатистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискаПервогоВхожденияДвухСловимяИФамилияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискаПервогоВхождениеФамилииСИнициаламиToolStripMenuItem;
    }
}

