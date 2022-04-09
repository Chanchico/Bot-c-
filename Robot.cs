using System;
namespace Bot {
    public class Robot : Object {
        private List<int[,]> Path = new List<int[,]>();
        private int Velocity { set; get;}

        private bool CubeGrabbed {set; get;}
        public Robot(){ }
       
        public Robot(int height, int width, int x, int y) {
            this.SetHeight(height);
            this.SetWidth(width);
            this.SetPosition(x, y);
            this.Velocity = 3; // 3 unit each 10 itération
        }

        public void SetCubeGrabbed(bool isGrabbed) { CubeGrabbed = isGrabbed; }

        public bool GetCubeGrabbed(){ return CubeGrabbed; }
        
        public List<int[,]> GetPath() { return Path; }

        public int[,] GetPath(int i) { return Path[i]; }

        public void MoveUp(){
            int y = GetPositionY();
            int x = GetPositionX();
            int[,] path = {{x, y}, {x, y - Velocity}};
            Path.Add(path);
            SetPositionY(y - Velocity);
        }

        public void MoveDown(){
            int y = GetPositionY();
            int x = GetPositionX();
            int[,] path = {{x, y}, {x, y + Velocity}};
            Path.Add(path);
            SetPositionY(y + Velocity);
        }     

        public void MoveRight(){
            int x = GetPositionX();
            int y = GetPositionY();
            int[,] path = {{x, y}, {x + Velocity, y}};
            Path.Add(path);
            SetPositionX(x + Velocity);
        }
        
        public void MoveLeft(){
            int y = GetPositionY();
            int x = GetPositionX();
            int[,] path = {{x, y}, {x - Velocity, y}};
            Path.Add(path);
            SetPositionX(x - Velocity);
        }


    }
}