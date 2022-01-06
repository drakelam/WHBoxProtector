# WHBoxProtector-
An open source tool to obfuscate .NET assembly files. Use the dnlib library. This is a small tool, I made to protect my copyright, simple but effective.


I used dnlib to write it out. (A little exercise). I used it for a while and stopped using it. However I still want to share it with friends, lovers. I believe, with this application and open source code will help you!


## Features

 1. String Encryption. 
 2. Micro Attribute. 
 3. Name Protection. 
 4. Anti-De4dot.
 5. Obfuscator.


### Software Main Menu

![enter image description here](https://raw.githubusercontent.com/drakelam/WHBoxProtector/main/246255453_329924618902004_7567053268457893486_n.jpg)


Result

![enter image description here](https://raw.githubusercontent.com/drakelam/WHBoxProtector/main/246804670_1274245213054737_2169483093746303312_n.jpg)


## Example
original :
```C#
 public partial class WebsiteTrafficBot : Form
    {
        public WebsiteTrafficBot()
        {
            InitializeComponent();
        }

        private string globalUrl = "";
        private int completed = 0;
        private int todo = 100;
        private void button1_Click(object sender, EventArgs e)
        {
            globalUrl = textBox1.Text;
            completed = 0;
            todo = decimal.ToInt32(numericUpDown1.Value);
            progressBar1.Maximum = todo;
            doView.Start();
        }

    }
```


ofbuscated :

```C#
public partial class WebsiteTrafficBot : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020A0 File Offset: 0x000002A0
		public WebsiteTrafficBot()
		{
			this.dل書งةd7اดا\u093Eาतعรसำवकع();
		}
		// Token: 0x04000001 RID: 1
		private string حत家jรل6\u094Dะ6紀لसa6\u094Deلतसस\u0902स\u094Dक\u0943林氏家族ᏢᏒᎾᏆᎬᏟᏆᎾᏒbᎽ\u0020ᎠᏒᎪᏦᎬᏞᎪm林氏家族स\u0902स\u094Dक\u0943 = Encoding.UTF8.GetString(Convert.FromBase64String(""));

		// Token: 0x04000002 RID: 2
		private int น氏ะาجلतلवस\u093E\u094Dل77لaةดปस\u0902स\u094Dक\u0943林氏家族ᏢᏒᎾᏆᎬᏟᏆᎾᏒbᎽ\u0020ᎠᏒᎪᏦᎬᏞᎪm林氏家族स\u0902स\u094Dक\u0943 = 0;

		// Token: 0x04000003 RID: 3
		private int aج\u0E397\u094Dา\u094Dस日اकاस氏اi族d\u093Eรस\u0902स\u094Dक\u0943林氏家族ᏢᏒᎾᏆᎬᏟᏆᎾᏒbᎽ\u0020ᎠᏒᎪᏦᎬᏞᎪm林氏家族स\u0902स\u094Dक\u0943 = 100;

		// Token: 0x06000002 RID: 2 RVA: 0x000020F0 File Offset: 0x000002F0
		private void aiก7า8\u0943ปcaلحعาi本لةعव(object sender, EventArgs e)
		{
			this.حत家jรل6\u094Dะ6紀لसa6\u094Deلतसस\u0902स\u094Dक\u0943林氏家族ᏢᏒᎾᏆᎬᏟᏆᎾᏒbᎽ\u0020ᎠᏒᎪᏦᎬᏞᎪm林氏家族स\u0902स\u094Dक\u0943 = this.सعا\u0902bकلddعbcาعا6اง\u094Dะस\u0902स\u094Dक\u0943林氏家族ᏢᏒᎾᏆᎬᏟᏆᎾᏒbᎽ\u0020ᎠᏒᎪᏦᎬᏞᎪm林氏家族स\u0902स\u094Dक\u0943.Text;
			this.น氏ะาجلतلवस\u093E\u094Dل77لaةดปस\u0902स\u094Dक\u0943林氏家族ᏢᏒᎾᏆᎬᏟᏆᎾᏒbᎽ\u0020ᎠᏒᎪᏦᎬᏞᎪm林氏家族स\u0902स\u094Dक\u0943 = 0;
			this.aج\u0E397\u094Dา\u094Dस日اकاस氏اi族d\u093Eรस\u0902स\u094Dक\u0943林氏家族ᏢᏒᎾᏆᎬᏟᏆᎾᏒbᎽ\u0020ᎠᏒᎪᏦᎬᏞᎪm林氏家族स\u0902स\u094Dक\u0943 = decimal.ToInt32(this.น6कمำاำة\u0E39u紀\u093Eกd\u094Dجस\u0E49عงस\u0902स\u094Dक\u0943林氏家族ᏢᏒᎾᏆᎬᏟᏆᎾᏒbᎽ\u0020ᎠᏒᎪᏦᎬᏞᎪm林氏家族स\u0902स\u094Dक\u0943.Value);
			this.ำa\u0902j紀لำतกdรक\u0E39ل氏\u0E49جjعะस\u0902स\u094Dक\u0943林氏家族ᏢᏒᎾᏆᎬᏟᏆᎾᏒbᎽ\u0020ᎠᏒᎪᏦᎬᏞᎪm林氏家族स\u0902स\u094Dक\u0943.Maximum = this.aج\u0E397\u094Dา\u094Dस日اकاस氏اi族d\u093Eรस\u0902स\u094Dक\u0943林氏家族ᏢᏒᎾᏆᎬᏟᏆᎾᏒbᎽ\u0020ᎠᏒᎪᏦᎬᏞᎪm林氏家族स\u0902स\u094Dक\u0943;
			this.uत7कu\u0943uดร氏\u0943सلดل氏ะcकdस\u0902स\u094Dक\u0943林氏家族ᏢᏒᎾᏆᎬᏟᏆᎾᏒbᎽ\u0020ᎠᏒᎪᏦᎬᏞᎪm林氏家族स\u0902स\u094Dक\u0943.Start();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000214C File Offset: 0x0000034C
		

	}
```


