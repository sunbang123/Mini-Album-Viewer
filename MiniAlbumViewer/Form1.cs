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
                    // 기존에 생성된 썸네일 초기화
                    flowLayoutPanel.Controls.Clear();

                    foreach(string imageFile in imageFiles)
                    {
                        PictureBox thumbBox = new PictureBox();

                        // 이미지 파일을 PictureBox로 로드
                        thumbBox.Image = Image.FromFile(imageFile);
                        thumbBox.SizeMode = PictureBoxSizeMode.Zoom;
                        thumbBox.Size = new Size(100, 100); // 썸네일 크기 설정

                        thumbBox.Tag = imageFile; // 이미지 파일 경로를 Tag에 저장

                        thumbBox.Click += ThumbBox_Click; // 클릭 이벤트 핸들러 등록

                        // FlowLayoutPanel에 PictureBox 추가
                        flowLayoutPanel.Controls.Add(thumbBox);
                    }
                }
                else
                {
                    MessageBox.Show("선택한 폴더에 이미지 파일이 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        void ThumbBox_Click(object sender, EventArgs e)
        {
            // 1. 누가 클릭되었는지(sender) 확인하고 PictureBox로 형변환
            PictureBox clickedThumb = (PictureBox)sender;

            // 2. 아까 Tag 주머니에 넣어둔 '원본 파일 경로'를 꺼내기
            string originalPath = clickedThumb.Tag.ToString();

            // 3. 꺼낸 경로의 이미지를 우측 메인 PictureBox에 띄우기
            pictureBox.Image = Image.FromFile(originalPath);
        }
    }
}
