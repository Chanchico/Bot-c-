namespace Bot {
    public class World {
        private int Height{ get; set;}
        private int Width{ get; set;}

        private Robot Robot{get;  set;}

        public World(int height_world, int width_world, Robot robot){
            Height = height_world;
            Width = width_world;
            Robot = robot;
        } 

        public Robot GetRobot(){ return Robot; }
        public int GetHeight(){ return Height; }
        public int GetWidth(){ return Width; }

        public void SetHeight(int height){ Height = height;}

        public void SetWidth(int width){ Width = width; }
    }
}