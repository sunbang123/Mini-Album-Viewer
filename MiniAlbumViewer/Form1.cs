namespace MiniAlbumViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFolder_Click(object sender, EventArgs e)
        {
            // FolderBrowerDialog 인스턴스 생성
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            // 대화상자를 열고 사용자가 폴더를 선택했는지 확인
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // 선택한 폴더 경로 가져오기
                string selectedPath = folderBrowserDialog.SelectedPath;

                // 폴더 내에서 이미지 확장자 파일만 가져오기
                string[] imageExtensions = { "*.jpg", "*.jpeg", "*.png", "*.bmp", "*.gif" };
                List<string> imageFiles = new List<string>();

                foreach(string ext in imageExtensions)
                {
                    imageFiles.AddRange(Directory.GetFiles(selectedPath, ext));
                }

                // 폴더에 이미지가 최소 1장 있는 경우 첫번째 이미지 표시
                if(imageFiles.Count > 0)
                {
                    pictureBox.Image = Image.FromFile(imageFiles[0]);
                }
                else
                {
                    MessageBox.Show("선택한 폴더에 이미지 파일이 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
