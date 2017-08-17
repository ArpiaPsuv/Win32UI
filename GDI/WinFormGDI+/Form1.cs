using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.IO;
using System.Reflection;

using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
namespace GDIPlusDemo
{
    /// <summary>
    /// Form1 ��ժҪ˵����
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem FadeInOut;
        private System.Windows.Forms.MenuItem GrayScale;
        private System.Windows.Forms.MenuItem Inverse;
        private System.Windows.Forms.MenuItem Emboss;
        private System.Windows.Forms.MenuItem CreatePenFromBrush;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem DashStyle_Custom;
        private System.Windows.Forms.MenuItem Pen_Align;
        private System.Windows.Forms.MenuItem Pen_Tranform;
        private System.Windows.Forms.MenuItem Pen_LineCap;
        private System.Windows.Forms.MenuItem Pen_TransColor;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem Brush_SolidBrush;
        private System.Windows.Forms.MenuItem Brush_FillVurve;
        private System.Windows.Forms.MenuItem Brush_HatchBrush;
        private System.Windows.Forms.MenuItem Brush_EnumAllStyle;
        private System.Windows.Forms.MenuItem Brush_SetRenderingOrigin;
        private System.Windows.Forms.MenuItem Brush_Texture;
        private System.Windows.Forms.MenuItem Brush_Texture_WrapMode;
        private System.Windows.Forms.MenuItem Brush_TextureTransform;
        private System.Windows.Forms.MenuItem Brush_GetTextureMatrix;
        private System.Windows.Forms.MenuItem Brush_LinearGradientBrush;
        private System.Windows.Forms.MenuItem Brush_LinearArrange;
        private System.Windows.Forms.MenuItem Brush_LinearGradientMode;
        private System.Windows.Forms.MenuItem Brush_LinearAngle;
        private System.Windows.Forms.MenuItem Brush_LinearInterpolation;
        private System.Windows.Forms.MenuItem Brush_LinearCustomize;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem Brush_LinearGradientBrush_BellShape;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem Brush_PathGradientBrush_Star;
        private System.Windows.Forms.MenuItem Brush_PathGradientBrush_Star2;
        private System.Windows.Forms.MenuItem Brush_Using_MorePathGradientBrush;
        private System.Windows.Forms.MenuItem Brush_PathGradientBrush_WrapMode;
        private System.Windows.Forms.MenuItem Brush_PathGradientBrush_CenterPoint;
        private System.Windows.Forms.MenuItem Brush_PathGradientBrush_InterpolationColors;
        private System.Windows.Forms.MenuItem Brsuh_PathGradietBrush_Focus;
        private System.Windows.Forms.MenuItem Brush_PathGradientBrush_Transform;
        private System.Windows.Forms.MenuItem Brsuh_LinearGradientBrush_UsingGamma;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem Font_UsingFontInGDIPlus;
        private System.Windows.Forms.MenuItem Font_EnumAllFonts;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem Font_EnhanceFontDialog;
        private System.Windows.Forms.MenuItem Font_UsingTextRenderHint;
        private System.Windows.Forms.MenuItem Font_Privatefontcollection;
        private System.Windows.Forms.MenuItem Font_Privatefontcollection2;
        private System.Windows.Forms.MenuItem Font_IsStyleAvailable;
        private System.Windows.Forms.MenuItem Font_Size;
        private System.Windows.Forms.MenuItem Font_BaseLine;
        private System.Windows.Forms.MenuItem Font_DrawString;
        private System.Windows.Forms.MenuItem Font_MeasureString;
        private System.Windows.Forms.MenuItem Font_MeasureString2;
        private System.Windows.Forms.MenuItem Font_ColumnTextOut;
        private System.Windows.Forms.MenuItem Font_StirngTrimming;
        private System.Windows.Forms.MenuItem Font_TextOutClip;
        private System.Windows.Forms.MenuItem Font_MeasureCharacterRanges;
        private System.Windows.Forms.MenuItem Font_TextoutDirection;
        private System.Windows.Forms.MenuItem Font_TextAlignment;
        private System.Windows.Forms.MenuItem Font_TextAlignment2;
        private System.Windows.Forms.MenuItem Font_TextoutUsingTabs;
        private System.Windows.Forms.MenuItem Font_UsingTabs;
        private System.Windows.Forms.MenuItem Font_TextoutHotkeyPrefix;
        private System.Windows.Forms.MenuItem Font_TextoutShadow;
        private System.Windows.Forms.MenuItem Font_TextoutHashline;
        private System.Windows.Forms.MenuItem Font_TextoutTexture;
        private System.Windows.Forms.MenuItem Font_TextoutGradient;
        private System.Windows.Forms.MenuItem Path_Construct;
        private System.Windows.Forms.MenuItem Path_AddLines;
        private System.Windows.Forms.MenuItem Path_CloseFigure;
        private System.Windows.Forms.MenuItem Path_FillPath;
        private System.Windows.Forms.MenuItem Path_AddSubPath;
        private System.Windows.Forms.MenuItem Path_GetSubPath;
        private System.Windows.Forms.MenuItem Path_GetPoints;
        private System.Windows.Forms.MenuItem Path_PathData;
        private System.Windows.Forms.MenuItem Path_ViewPointFLAG;
        private System.Windows.Forms.MenuItem Path_SubPathRange;
        private System.Windows.Forms.MenuItem Path��Flatten;
        private System.Windows.Forms.MenuItem Path_Warp;
        private System.Windows.Forms.MenuItem Path_Transform;
        private System.Windows.Forms.MenuItem Path_Widen;
        private System.Windows.Forms.MenuItem Path_WidenDemo;
        private System.Windows.Forms.MenuItem Region��FromPath;
        private System.Windows.Forms.MenuItem Region_Calculate;
        private System.Windows.Forms.MenuItem Region_GetRects;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem Transform;
        private System.Windows.Forms.MenuItem TranslateTransform;
        private System.Windows.Forms.MenuItem RotateTransform;
        private System.Windows.Forms.MenuItem DrawWatch;
        private System.Windows.Forms.MenuItem ScaleTransform;
        private System.Windows.Forms.MenuItem RectScale;
        private System.Windows.Forms.MenuItem FontRotate;
        private System.Windows.Forms.MenuItem Matrix_ListElements;
        private System.Windows.Forms.MenuItem MatrixPos;
        private System.Windows.Forms.MenuItem Martrix_Invert;
        private System.Windows.Forms.MenuItem Matrix_Multiply;
        private System.Windows.Forms.MenuItem Matrix_TransformPoints;
        private System.Windows.Forms.MenuItem Matrix_TransformPoints2;
        private System.Windows.Forms.MenuItem Matrix_TransformVectors;
        private System.Windows.Forms.MenuItem Matrix_RotateAt;
        private System.Windows.Forms.MenuItem Matrix_Shear;
        private System.Windows.Forms.MenuItem Matrix_TextoutShear;
        private System.Windows.Forms.MenuItem Matrix_ChangeFontHeight;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.MenuItem ColorMatrix��Start;
        private System.Windows.Forms.MenuItem TranslateColor;
        private System.Windows.Forms.MenuItem ScaleColor;
        private System.Windows.Forms.MenuItem RotateColor;
        private System.Windows.Forms.MenuItem ColorShear;
        private System.Windows.Forms.MenuItem ColorRemap;
        private System.Windows.Forms.MenuItem SetRGBOutputChannel;
        private System.Windows.Forms.MenuItem menuItem13;
        private System.Windows.Forms.MenuItem Metafile;
        private System.Windows.Forms.MenuItem CroppingAndScaling;
        private System.Windows.Forms.MenuItem UsingInterpolationMode;
        private System.Windows.Forms.MenuItem RotateFlip;
        private System.Windows.Forms.MenuItem ImageSkewing;
        private System.Windows.Forms.MenuItem Cubeimage;
        private System.Windows.Forms.MenuItem ThumbnailImage;
        private System.Windows.Forms.MenuItem Clone;
        private System.Windows.Forms.MenuItem Picturescale;
        private System.Windows.Forms.MenuItem menuItem15;
        private System.Windows.Forms.MenuItem ImageAttributesSetNoOp;
        private System.Windows.Forms.MenuItem SetColorMatrices;
        private System.Windows.Forms.MenuItem SetOutputChannelColorProfile;
        private System.Windows.Forms.MenuItem Gammaadjust;
        private System.Windows.Forms.MenuItem SetOutputChannel;
        private System.Windows.Forms.MenuItem Colorkey;
        private System.Windows.Forms.MenuItem Setthreshold;
        private System.Windows.Forms.MenuItem AdjustedPalette;
        private System.Windows.Forms.MenuItem SetWrapMode;
        private System.Windows.Forms.MenuItem menuItem16;
        private System.Windows.Forms.MenuItem ListAllImageEncoders;
        private System.Windows.Forms.MenuItem ListImageEncoder_Detail;
        private System.Windows.Forms.MenuItem ListImageDecoder;
        private System.Windows.Forms.MenuItem GetEncoderParameter;
        private System.Windows.Forms.MenuItem GetAllEncoderParameter;
        private System.Windows.Forms.MenuItem menuItem17;
        private System.Windows.Forms.MenuItem MultipleFrameImage;
        private System.Windows.Forms.MenuItem SaveBmp2tif;
        private System.Windows.Forms.MenuItem SaveBMP2JPG;
        private System.Windows.Forms.MenuItem TransformingJPEG;
        private System.Windows.Forms.MenuItem GetImageFromMultyFrame;
        private System.Windows.Forms.MenuItem QueryImage;
        private System.Windows.Forms.MenuItem SetProp;
        private System.Windows.Forms.MenuItem menuItem18;
        private System.Windows.Forms.MenuItem OnCanvas;
        private System.Windows.Forms.MenuItem OnWood;
        private System.Windows.Forms.MenuItem Flashligt;
        private System.Windows.Forms.MenuItem BlurAndSharpen;
        private IContainer components;

        public Form1()
        {
            //
            // Windows ���������֧���������
            //
            InitializeComponent();


            //
            // TODO: �� InitializeComponent ���ú�����κι��캯������
            //
        }

        /// <summary>
        /// ������������ʹ�õ���Դ��
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
        /// �˷��������ݡ�
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.CreatePenFromBrush = new System.Windows.Forms.MenuItem();
            this.DashStyle_Custom = new System.Windows.Forms.MenuItem();
            this.Pen_Align = new System.Windows.Forms.MenuItem();
            this.Pen_Tranform = new System.Windows.Forms.MenuItem();
            this.Pen_LineCap = new System.Windows.Forms.MenuItem();
            this.Pen_TransColor = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.Brush_SolidBrush = new System.Windows.Forms.MenuItem();
            this.Brush_FillVurve = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.Brush_HatchBrush = new System.Windows.Forms.MenuItem();
            this.Brush_EnumAllStyle = new System.Windows.Forms.MenuItem();
            this.Brush_SetRenderingOrigin = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.Brush_Texture = new System.Windows.Forms.MenuItem();
            this.Brush_Texture_WrapMode = new System.Windows.Forms.MenuItem();
            this.Brush_TextureTransform = new System.Windows.Forms.MenuItem();
            this.Brush_GetTextureMatrix = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.Brush_LinearGradientBrush = new System.Windows.Forms.MenuItem();
            this.Brush_LinearArrange = new System.Windows.Forms.MenuItem();
            this.Brush_LinearInterpolation = new System.Windows.Forms.MenuItem();
            this.Brush_LinearGradientMode = new System.Windows.Forms.MenuItem();
            this.Brush_LinearAngle = new System.Windows.Forms.MenuItem();
            this.Brush_LinearCustomize = new System.Windows.Forms.MenuItem();
            this.Brush_LinearGradientBrush_BellShape = new System.Windows.Forms.MenuItem();
            this.Brsuh_LinearGradientBrush_UsingGamma = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.Brush_PathGradientBrush_Star = new System.Windows.Forms.MenuItem();
            this.Brush_PathGradientBrush_Star2 = new System.Windows.Forms.MenuItem();
            this.Brush_Using_MorePathGradientBrush = new System.Windows.Forms.MenuItem();
            this.Brush_PathGradientBrush_WrapMode = new System.Windows.Forms.MenuItem();
            this.Brush_PathGradientBrush_CenterPoint = new System.Windows.Forms.MenuItem();
            this.Brush_PathGradientBrush_InterpolationColors = new System.Windows.Forms.MenuItem();
            this.Brsuh_PathGradietBrush_Focus = new System.Windows.Forms.MenuItem();
            this.Brush_PathGradientBrush_Transform = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.Font_UsingFontInGDIPlus = new System.Windows.Forms.MenuItem();
            this.Font_EnumAllFonts = new System.Windows.Forms.MenuItem();
            this.Font_EnhanceFontDialog = new System.Windows.Forms.MenuItem();
            this.Font_UsingTextRenderHint = new System.Windows.Forms.MenuItem();
            this.Font_Privatefontcollection = new System.Windows.Forms.MenuItem();
            this.Font_Privatefontcollection2 = new System.Windows.Forms.MenuItem();
            this.Font_IsStyleAvailable = new System.Windows.Forms.MenuItem();
            this.Font_Size = new System.Windows.Forms.MenuItem();
            this.Font_BaseLine = new System.Windows.Forms.MenuItem();
            this.Font_DrawString = new System.Windows.Forms.MenuItem();
            this.Font_MeasureString = new System.Windows.Forms.MenuItem();
            this.Font_MeasureString2 = new System.Windows.Forms.MenuItem();
            this.Font_ColumnTextOut = new System.Windows.Forms.MenuItem();
            this.Font_StirngTrimming = new System.Windows.Forms.MenuItem();
            this.Font_TextOutClip = new System.Windows.Forms.MenuItem();
            this.Font_MeasureCharacterRanges = new System.Windows.Forms.MenuItem();
            this.Font_TextoutDirection = new System.Windows.Forms.MenuItem();
            this.Font_TextAlignment = new System.Windows.Forms.MenuItem();
            this.Font_TextAlignment2 = new System.Windows.Forms.MenuItem();
            this.Font_TextoutUsingTabs = new System.Windows.Forms.MenuItem();
            this.Font_UsingTabs = new System.Windows.Forms.MenuItem();
            this.Font_TextoutHotkeyPrefix = new System.Windows.Forms.MenuItem();
            this.Font_TextoutShadow = new System.Windows.Forms.MenuItem();
            this.Font_TextoutHashline = new System.Windows.Forms.MenuItem();
            this.Font_TextoutTexture = new System.Windows.Forms.MenuItem();
            this.Font_TextoutGradient = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.Path_Construct = new System.Windows.Forms.MenuItem();
            this.Path_AddLines = new System.Windows.Forms.MenuItem();
            this.Path_CloseFigure = new System.Windows.Forms.MenuItem();
            this.Path_FillPath = new System.Windows.Forms.MenuItem();
            this.Path_AddSubPath = new System.Windows.Forms.MenuItem();
            this.Path_GetSubPath = new System.Windows.Forms.MenuItem();
            this.Path_GetPoints = new System.Windows.Forms.MenuItem();
            this.Path_PathData = new System.Windows.Forms.MenuItem();
            this.Path_ViewPointFLAG = new System.Windows.Forms.MenuItem();
            this.Path_SubPathRange = new System.Windows.Forms.MenuItem();
            this.Path��Flatten = new System.Windows.Forms.MenuItem();
            this.Path_Warp = new System.Windows.Forms.MenuItem();
            this.Path_Transform = new System.Windows.Forms.MenuItem();
            this.Path_Widen = new System.Windows.Forms.MenuItem();
            this.Path_WidenDemo = new System.Windows.Forms.MenuItem();
            this.Region��FromPath = new System.Windows.Forms.MenuItem();
            this.Region_Calculate = new System.Windows.Forms.MenuItem();
            this.Region_GetRects = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.Transform = new System.Windows.Forms.MenuItem();
            this.TranslateTransform = new System.Windows.Forms.MenuItem();
            this.RotateTransform = new System.Windows.Forms.MenuItem();
            this.DrawWatch = new System.Windows.Forms.MenuItem();
            this.ScaleTransform = new System.Windows.Forms.MenuItem();
            this.RectScale = new System.Windows.Forms.MenuItem();
            this.FontRotate = new System.Windows.Forms.MenuItem();
            this.Matrix_ListElements = new System.Windows.Forms.MenuItem();
            this.MatrixPos = new System.Windows.Forms.MenuItem();
            this.Martrix_Invert = new System.Windows.Forms.MenuItem();
            this.Matrix_Multiply = new System.Windows.Forms.MenuItem();
            this.Matrix_TransformPoints = new System.Windows.Forms.MenuItem();
            this.Matrix_TransformPoints2 = new System.Windows.Forms.MenuItem();
            this.Matrix_TransformVectors = new System.Windows.Forms.MenuItem();
            this.Matrix_RotateAt = new System.Windows.Forms.MenuItem();
            this.Matrix_Shear = new System.Windows.Forms.MenuItem();
            this.Matrix_TextoutShear = new System.Windows.Forms.MenuItem();
            this.Matrix_ChangeFontHeight = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.ColorMatrix��Start = new System.Windows.Forms.MenuItem();
            this.TranslateColor = new System.Windows.Forms.MenuItem();
            this.ScaleColor = new System.Windows.Forms.MenuItem();
            this.RotateColor = new System.Windows.Forms.MenuItem();
            this.ColorShear = new System.Windows.Forms.MenuItem();
            this.ColorRemap = new System.Windows.Forms.MenuItem();
            this.SetRGBOutputChannel = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.Metafile = new System.Windows.Forms.MenuItem();
            this.CroppingAndScaling = new System.Windows.Forms.MenuItem();
            this.UsingInterpolationMode = new System.Windows.Forms.MenuItem();
            this.RotateFlip = new System.Windows.Forms.MenuItem();
            this.ImageSkewing = new System.Windows.Forms.MenuItem();
            this.Cubeimage = new System.Windows.Forms.MenuItem();
            this.ThumbnailImage = new System.Windows.Forms.MenuItem();
            this.Clone = new System.Windows.Forms.MenuItem();
            this.Picturescale = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.ImageAttributesSetNoOp = new System.Windows.Forms.MenuItem();
            this.SetColorMatrices = new System.Windows.Forms.MenuItem();
            this.SetOutputChannelColorProfile = new System.Windows.Forms.MenuItem();
            this.Gammaadjust = new System.Windows.Forms.MenuItem();
            this.SetOutputChannel = new System.Windows.Forms.MenuItem();
            this.Colorkey = new System.Windows.Forms.MenuItem();
            this.Setthreshold = new System.Windows.Forms.MenuItem();
            this.AdjustedPalette = new System.Windows.Forms.MenuItem();
            this.SetWrapMode = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.ListAllImageEncoders = new System.Windows.Forms.MenuItem();
            this.ListImageEncoder_Detail = new System.Windows.Forms.MenuItem();
            this.ListImageDecoder = new System.Windows.Forms.MenuItem();
            this.GetEncoderParameter = new System.Windows.Forms.MenuItem();
            this.GetAllEncoderParameter = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.SaveBmp2tif = new System.Windows.Forms.MenuItem();
            this.SaveBMP2JPG = new System.Windows.Forms.MenuItem();
            this.TransformingJPEG = new System.Windows.Forms.MenuItem();
            this.MultipleFrameImage = new System.Windows.Forms.MenuItem();
            this.GetImageFromMultyFrame = new System.Windows.Forms.MenuItem();
            this.QueryImage = new System.Windows.Forms.MenuItem();
            this.SetProp = new System.Windows.Forms.MenuItem();
            this.menuItem18 = new System.Windows.Forms.MenuItem();
            this.FadeInOut = new System.Windows.Forms.MenuItem();
            this.GrayScale = new System.Windows.Forms.MenuItem();
            this.Inverse = new System.Windows.Forms.MenuItem();
            this.Emboss = new System.Windows.Forms.MenuItem();
            this.OnCanvas = new System.Windows.Forms.MenuItem();
            this.OnWood = new System.Windows.Forms.MenuItem();
            this.Flashligt = new System.Windows.Forms.MenuItem();
            this.BlurAndSharpen = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem3,
            this.menuItem8,
            this.menuItem9,
            this.menuItem11,
            this.menuItem12,
            this.menuItem13,
            this.menuItem15,
            this.menuItem16,
            this.menuItem18});
            this.menuItem1.Text = "GDI+���";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.CreatePenFromBrush,
            this.DashStyle_Custom,
            this.Pen_Align,
            this.Pen_Tranform,
            this.Pen_LineCap,
            this.Pen_TransColor});
            this.menuItem2.Text = "����";
            // 
            // CreatePenFromBrush
            // 
            this.CreatePenFromBrush.Index = 0;
            this.CreatePenFromBrush.Text = "�ӻ�ˢ�й��컭��";
            this.CreatePenFromBrush.Click += new System.EventHandler(this.CreatePenFromBrush_Click);
            // 
            // DashStyle_Custom
            // 
            this.DashStyle_Custom.Index = 1;
            this.DashStyle_Custom.Text = "�Զ�������";
            this.DashStyle_Custom.Click += new System.EventHandler(this.DashStyle_Custom_Click);
            // 
            // Pen_Align
            // 
            this.Pen_Align.Index = 2;
            this.Pen_Align.Text = "���ʵĶ��뷽ʽ";
            this.Pen_Align.Click += new System.EventHandler(this.Pen_Align_Click);
            // 
            // Pen_Tranform
            // 
            this.Pen_Tranform.Index = 3;
            this.Pen_Tranform.Text = "���ʵ���������ת";
            this.Pen_Tranform.Click += new System.EventHandler(this.Pen_Tranform_Click);
            // 
            // Pen_LineCap
            // 
            this.Pen_LineCap.Index = 4;
            this.Pen_LineCap.Text = "���ʵ���ñ����";
            this.Pen_LineCap.Click += new System.EventHandler(this.Pen_LineCap_Click);
            // 
            // Pen_TransColor
            // 
            this.Pen_TransColor.Index = 5;
            this.Pen_TransColor.Text = "���ʵ�͸����֧��";
            this.Pen_TransColor.Click += new System.EventHandler(this.Pen_TransColor_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem5,
            this.menuItem10,
            this.menuItem7,
            this.menuItem6,
            this.menuItem4});
            this.menuItem3.Text = "��ˢ";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 0;
            this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Brush_SolidBrush,
            this.Brush_FillVurve});
            this.menuItem5.Text = "��ɫ��ˢ��ʹ��";
            // 
            // Brush_SolidBrush
            // 
            this.Brush_SolidBrush.Index = 0;
            this.Brush_SolidBrush.Text = "�򵥵ĵ�ɫ��ˢ";
            this.Brush_SolidBrush.Click += new System.EventHandler(this.Brush_SolidBrush_Click);
            // 
            // Brush_FillVurve
            // 
            this.Brush_FillVurve.Index = 1;
            this.Brush_FillVurve.Text = "�����Ҷ����";
            this.Brush_FillVurve.Click += new System.EventHandler(this.Brush_FillVurve_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 1;
            this.menuItem10.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Brush_HatchBrush,
            this.Brush_EnumAllStyle,
            this.Brush_SetRenderingOrigin});
            this.menuItem10.Text = "Ӱ�߻�ˢ��ʹ��";
            // 
            // Brush_HatchBrush
            // 
            this.Brush_HatchBrush.Index = 0;
            this.Brush_HatchBrush.Text = "Ӱ�߻�ˢ";
            this.Brush_HatchBrush.Click += new System.EventHandler(this.Brush_HatchBrush_Click);
            // 
            // Brush_EnumAllStyle
            // 
            this.Brush_EnumAllStyle.Index = 1;
            this.Brush_EnumAllStyle.Text = "ö������Ӱ�߻�ˢ���";
            this.Brush_EnumAllStyle.Click += new System.EventHandler(this.Brush_EnumAllStyle_Click);
            // 
            // Brush_SetRenderingOrigin
            // 
            this.Brush_SetRenderingOrigin.Index = 2;
            this.Brush_SetRenderingOrigin.Text = "���û���ԭ��";
            this.Brush_SetRenderingOrigin.Click += new System.EventHandler(this.Brush_SetRenderingOrigin_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 2;
            this.menuItem7.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Brush_Texture,
            this.Brush_Texture_WrapMode,
            this.Brush_TextureTransform,
            this.Brush_GetTextureMatrix});
            this.menuItem7.Text = "����ˢ";
            // 
            // Brush_Texture
            // 
            this.Brush_Texture.Index = 0;
            this.Brush_Texture.Text = "����ˢ�Ļ���ʹ��";
            this.Brush_Texture.Click += new System.EventHandler(this.Brush_Texture_Click);
            // 
            // Brush_Texture_WrapMode
            // 
            this.Brush_Texture_WrapMode.Index = 1;
            this.Brush_Texture_WrapMode.Text = "����ˢ�����з�ʽ";
            this.Brush_Texture_WrapMode.Click += new System.EventHandler(this.Brush_Texture_WrapMode_Click);
            // 
            // Brush_TextureTransform
            // 
            this.Brush_TextureTransform.Index = 2;
            this.Brush_TextureTransform.Text = "����ˢ�ı任";
            this.Brush_TextureTransform.Click += new System.EventHandler(this.Brush_TextureTransform_Click);
            // 
            // Brush_GetTextureMatrix
            // 
            this.Brush_GetTextureMatrix.Index = 3;
            this.Brush_GetTextureMatrix.Text = "��ѯ��ˢ�ı任��Ϣ";
            this.Brush_GetTextureMatrix.Click += new System.EventHandler(this.Brush_GetTextureMatrix_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 3;
            this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Brush_LinearGradientBrush,
            this.Brush_LinearArrange,
            this.Brush_LinearInterpolation,
            this.Brush_LinearGradientMode,
            this.Brush_LinearAngle,
            this.Brush_LinearCustomize,
            this.Brush_LinearGradientBrush_BellShape,
            this.Brsuh_LinearGradientBrush_UsingGamma});
            this.menuItem6.Text = "���Խ��仭ˢ��ʹ��";
            // 
            // Brush_LinearGradientBrush
            // 
            this.Brush_LinearGradientBrush.Index = 0;
            this.Brush_LinearGradientBrush.Text = "���Խ��仭ˢ";
            this.Brush_LinearGradientBrush.Click += new System.EventHandler(this.Brush_LinearGradientBrush_Click);
            // 
            // Brush_LinearArrange
            // 
            this.Brush_LinearArrange.Index = 1;
            this.Brush_LinearArrange.Text = "���仭ˢ�Ĳ�ͬ��䷽ʽ";
            this.Brush_LinearArrange.Click += new System.EventHandler(this.Brush_LinearArrange_Click);
            // 
            // Brush_LinearInterpolation
            // 
            this.Brush_LinearInterpolation.Index = 2;
            this.Brush_LinearInterpolation.Text = "��ɫ���仭ˢ";
            this.Brush_LinearInterpolation.Click += new System.EventHandler(this.Brush_LinearInterpolation_Click);
            // 
            // Brush_LinearGradientMode
            // 
            this.Brush_LinearGradientMode.Index = 3;
            this.Brush_LinearGradientMode.Text = "ʹ�ý��仭ˢ�Ľ���ģʽ";
            this.Brush_LinearGradientMode.Click += new System.EventHandler(this.Brush_LinearGradientMode_Click);
            // 
            // Brush_LinearAngle
            // 
            this.Brush_LinearAngle.Index = 4;
            this.Brush_LinearAngle.Text = "����������ƫת�Ƕ�";
            this.Brush_LinearAngle.Click += new System.EventHandler(this.Brush_LinearAngle_Click);
            // 
            // Brush_LinearCustomize
            // 
            this.Brush_LinearCustomize.Index = 5;
            this.Brush_LinearCustomize.Text = "�Զ������Խ��仭ˢ�Ľ������";
            this.Brush_LinearCustomize.Click += new System.EventHandler(this.Brush_LinearCustomize_Click);
            // 
            // Brush_LinearGradientBrush_BellShape
            // 
            this.Brush_LinearGradientBrush_BellShape.Index = 6;
            this.Brush_LinearGradientBrush_BellShape.Text = "�������߽���";
            this.Brush_LinearGradientBrush_BellShape.Click += new System.EventHandler(this.Brush_LinearGradientBrush_BellShape_Click);
            // 
            // Brsuh_LinearGradientBrush_UsingGamma
            // 
            this.Brsuh_LinearGradientBrush_UsingGamma.Index = 7;
            this.Brsuh_LinearGradientBrush_UsingGamma.Text = "����GammaУ��";
            this.Brsuh_LinearGradientBrush_UsingGamma.Click += new System.EventHandler(this.Brsuh_LinearGradientBrush_UsingGamma_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 4;
            this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Brush_PathGradientBrush_Star,
            this.Brush_PathGradientBrush_Star2,
            this.Brush_Using_MorePathGradientBrush,
            this.Brush_PathGradientBrush_WrapMode,
            this.Brush_PathGradientBrush_CenterPoint,
            this.Brush_PathGradientBrush_InterpolationColors,
            this.Brsuh_PathGradietBrush_Focus,
            this.Brush_PathGradientBrush_Transform});
            this.menuItem4.Text = "·�����仭ˢ";
            // 
            // Brush_PathGradientBrush_Star
            // 
            this.Brush_PathGradientBrush_Star.Index = 0;
            this.Brush_PathGradientBrush_Star.Text = "��������";
            this.Brush_PathGradientBrush_Star.Click += new System.EventHandler(this.Brush_PathGradientBrush_Star_Click);
            // 
            // Brush_PathGradientBrush_Star2
            // 
            this.Brush_PathGradientBrush_Star2.Index = 1;
            this.Brush_PathGradientBrush_Star2.Text = "��������(2)";
            this.Brush_PathGradientBrush_Star2.Click += new System.EventHandler(this.Brush_PathGradientBrush_Star2_Click);
            // 
            // Brush_Using_MorePathGradientBrush
            // 
            this.Brush_Using_MorePathGradientBrush.Index = 2;
            this.Brush_Using_MorePathGradientBrush.Text = "ʹ�ò�ͬ��·�����仭ˢ";
            this.Brush_Using_MorePathGradientBrush.Click += new System.EventHandler(this.Brush_Using_MorePathGradientBrush_Click);
            // 
            // Brush_PathGradientBrush_WrapMode
            // 
            this.Brush_PathGradientBrush_WrapMode.Index = 3;
            this.Brush_PathGradientBrush_WrapMode.Text = "·�����仭ˢ�����з�ʽ";
            this.Brush_PathGradientBrush_WrapMode.Click += new System.EventHandler(this.Brush_PathGradientBrush_WrapMode_Click);
            // 
            // Brush_PathGradientBrush_CenterPoint
            // 
            this.Brush_PathGradientBrush_CenterPoint.Index = 4;
            this.Brush_PathGradientBrush_CenterPoint.Text = "����·�����仭ˢ�����ĵ�";
            this.Brush_PathGradientBrush_CenterPoint.Click += new System.EventHandler(this.Brush_PathGradientBrush_CenterPoint_Click);
            // 
            // Brush_PathGradientBrush_InterpolationColors
            // 
            this.Brush_PathGradientBrush_InterpolationColors.Index = 5;
            this.Brush_PathGradientBrush_InterpolationColors.Text = "ʹ�ö�ɫ����";
            this.Brush_PathGradientBrush_InterpolationColors.Click += new System.EventHandler(this.Brush_PathGradientBrush_InterpolationColors_Click);
            // 
            // Brsuh_PathGradietBrush_Focus
            // 
            this.Brsuh_PathGradietBrush_Focus.Index = 6;
            this.Brsuh_PathGradietBrush_Focus.Text = "���Ļ�ˢ�Ľ������ű���";
            this.Brsuh_PathGradietBrush_Focus.Click += new System.EventHandler(this.Brsuh_PathGradietBrush_Focus_Click);
            // 
            // Brush_PathGradientBrush_Transform
            // 
            this.Brush_PathGradientBrush_Transform.Index = 7;
            this.Brush_PathGradientBrush_Transform.Text = "·�����仭ˢ�ı任";
            this.Brush_PathGradientBrush_Transform.Click += new System.EventHandler(this.Brush_PathGradientBrush_Transform_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 2;
            this.menuItem8.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Font_UsingFontInGDIPlus,
            this.Font_EnumAllFonts,
            this.Font_EnhanceFontDialog,
            this.Font_UsingTextRenderHint,
            this.Font_Privatefontcollection,
            this.Font_Privatefontcollection2,
            this.Font_IsStyleAvailable,
            this.Font_Size,
            this.Font_BaseLine,
            this.Font_DrawString,
            this.Font_MeasureString,
            this.Font_MeasureString2,
            this.Font_ColumnTextOut,
            this.Font_StirngTrimming,
            this.Font_TextOutClip,
            this.Font_MeasureCharacterRanges,
            this.Font_TextoutDirection,
            this.Font_TextAlignment,
            this.Font_TextAlignment2,
            this.Font_TextoutUsingTabs,
            this.Font_UsingTabs,
            this.Font_TextoutHotkeyPrefix,
            this.Font_TextoutShadow,
            this.Font_TextoutHashline,
            this.Font_TextoutTexture,
            this.Font_TextoutGradient});
            this.menuItem8.Text = "�ı�������";
            // 
            // Font_UsingFontInGDIPlus
            // 
            this.Font_UsingFontInGDIPlus.Index = 0;
            this.Font_UsingFontInGDIPlus.Text = "��GDI+��ʹ������(&A)";
            this.Font_UsingFontInGDIPlus.Click += new System.EventHandler(this.Font_UsingFontInGDIPlus_Click);
            // 
            // Font_EnumAllFonts
            // 
            this.Font_EnumAllFonts.Index = 1;
            this.Font_EnumAllFonts.Text = "��ȡ�Ѱ�װ������";
            this.Font_EnumAllFonts.Click += new System.EventHandler(this.Font_EnumAllFonts_Click);
            // 
            // Font_EnhanceFontDialog
            // 
            this.Font_EnhanceFontDialog.Index = 2;
            this.Font_EnhanceFontDialog.Text = "��ǿ������ѡ��Ի���";
            this.Font_EnhanceFontDialog.Click += new System.EventHandler(this.Font_EnhanceFontDialog_Click);
            // 
            // Font_UsingTextRenderHint
            // 
            this.Font_UsingTextRenderHint.Index = 3;
            this.Font_UsingTextRenderHint.Text = "��������ı�Ե����ʽ";
            this.Font_UsingTextRenderHint.Click += new System.EventHandler(this.Font_UsingTextRenderHint_Click);
            // 
            // Font_Privatefontcollection
            // 
            this.Font_Privatefontcollection.Index = 4;
            this.Font_Privatefontcollection.Text = "ʹ��˽�����弯��";
            this.Font_Privatefontcollection.Click += new System.EventHandler(this.Font_Privatefontcollection_Click);
            // 
            // Font_Privatefontcollection2
            // 
            this.Font_Privatefontcollection2.Index = 5;
            this.Font_Privatefontcollection2.Text = "��˽�����弯����ʹ�ö������";
            this.Font_Privatefontcollection2.Click += new System.EventHandler(this.Font_Privatefontcollection2_Click);
            // 
            // Font_IsStyleAvailable
            // 
            this.Font_IsStyleAvailable.Index = 6;
            this.Font_IsStyleAvailable.Text = "��˽�����弯���м��������Ϣ�Ŀ�����";
            this.Font_IsStyleAvailable.Click += new System.EventHandler(this.Font_IsStyleAvailable_Click);
            // 
            // Font_Size
            // 
            this.Font_Size.Index = 7;
            this.Font_Size.Text = "�ڳ����з�������(ϵ��)�Ĵ�С��Ϣ";
            this.Font_Size.Click += new System.EventHandler(this.Font_Size_Click);
            // 
            // Font_BaseLine
            // 
            this.Font_BaseLine.Index = 8;
            this.Font_BaseLine.Text = "�����ı�����Ļ���";
            this.Font_BaseLine.Click += new System.EventHandler(this.Font_BaseLine_Click);
            // 
            // Font_DrawString
            // 
            this.Font_DrawString.Index = 9;
            this.Font_DrawString.Text = "ʹ��GDI+�����ı�";
            this.Font_DrawString.Click += new System.EventHandler(this.Font_DrawString_Click);
            // 
            // Font_MeasureString
            // 
            this.Font_MeasureString.Index = 10;
            this.Font_MeasureString.Text = "�����ı�";
            this.Font_MeasureString.Click += new System.EventHandler(this.Font_MeasureString_Click);
            // 
            // Font_MeasureString2
            // 
            this.Font_MeasureString2.Index = 11;
            this.Font_MeasureString2.Text = "����ָ���������ܹ���ʾ���ַ�����������";
            this.Font_MeasureString2.Click += new System.EventHandler(this.Font_MeasureString2_Click);
            // 
            // Font_ColumnTextOut
            // 
            this.Font_ColumnTextOut.Index = 12;
            this.Font_ColumnTextOut.Text = "ʵ���ļ��ķ�����ʾ";
            this.Font_ColumnTextOut.Click += new System.EventHandler(this.Font_ColumnTextOut_Click);
            // 
            // Font_StirngTrimming
            // 
            this.Font_StirngTrimming.Index = 13;
            this.Font_StirngTrimming.Text = "�ַ�����ȥβ";
            this.Font_StirngTrimming.Click += new System.EventHandler(this.Font_StirngTrimming_Click);
            // 
            // Font_TextOutClip
            // 
            this.Font_TextOutClip.Index = 14;
            this.Font_TextOutClip.Text = "�ı�����ļ�������";
            this.Font_TextOutClip.Click += new System.EventHandler(this.Font_TextOutClip_Click);
            // 
            // Font_MeasureCharacterRanges
            // 
            this.Font_MeasureCharacterRanges.Index = 15;
            this.Font_MeasureCharacterRanges.Text = "�����ı��ľֲ��������";
            this.Font_MeasureCharacterRanges.Click += new System.EventHandler(this.Font_MeasureCharacterRanges_Click);
            // 
            // Font_TextoutDirection
            // 
            this.Font_TextoutDirection.Index = 16;
            this.Font_TextoutDirection.Text = "�����ı��������";
            this.Font_TextoutDirection.Click += new System.EventHandler(this.Font_TextoutDirection_Click);
            // 
            // Font_TextAlignment
            // 
            this.Font_TextAlignment.Index = 17;
            this.Font_TextAlignment.Text = "�����ı����뷽ʽ";
            this.Font_TextAlignment.Click += new System.EventHandler(this.Font_TextAlignment_Click);
            // 
            // Font_TextAlignment2
            // 
            this.Font_TextAlignment2.Index = 18;
            this.Font_TextAlignment2.Text = "�����ı����뷽ʽ(2)";
            this.Font_TextAlignment2.Click += new System.EventHandler(this.Font_TextAlignment2_Click);
            // 
            // Font_TextoutUsingTabs
            // 
            this.Font_TextoutUsingTabs.Index = 19;
            this.Font_TextoutUsingTabs.Text = "���úͻ�ȡ�Ʊ����Ϣ";
            this.Font_TextoutUsingTabs.Click += new System.EventHandler(this.Font_TextoutUsingTabs_Click);
            // 
            // Font_UsingTabs
            // 
            this.Font_UsingTabs.Index = 20;
            this.Font_UsingTabs.Text = "ʹ���Ʊ�λ���б�����";
            this.Font_UsingTabs.Click += new System.EventHandler(this.Font_UsingTabs_Click);
            // 
            // Font_TextoutHotkeyPrefix
            // 
            this.Font_TextoutHotkeyPrefix.Index = 21;
            this.Font_TextoutHotkeyPrefix.Text = "��ݼ�ǰ���ַ���ʾ";
            this.Font_TextoutHotkeyPrefix.Click += new System.EventHandler(this.Font_TextoutHotkeyPrefix_Click);
            // 
            // Font_TextoutShadow
            // 
            this.Font_TextoutShadow.Index = 22;
            this.Font_TextoutShadow.Text = "��Ӱ����Ч";
            this.Font_TextoutShadow.Click += new System.EventHandler(this.Font_TextoutShadow_Click);
            // 
            // Font_TextoutHashline
            // 
            this.Font_TextoutHashline.Index = 23;
            this.Font_TextoutHashline.Text = "ʹ��Ӱ�߻�ˢ�����ı�";
            this.Font_TextoutHashline.Click += new System.EventHandler(this.Font_TextoutHashline_Click);
            // 
            // Font_TextoutTexture
            // 
            this.Font_TextoutTexture.Index = 24;
            this.Font_TextoutTexture.Text = "����������";
            this.Font_TextoutTexture.Click += new System.EventHandler(this.Font_TextoutTexture_Click);
            // 
            // Font_TextoutGradient
            // 
            this.Font_TextoutGradient.Index = 25;
            this.Font_TextoutGradient.Text = "ʹ�ý��仭ˢ�����ı�";
            this.Font_TextoutGradient.Click += new System.EventHandler(this.Font_TextoutGradient_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 3;
            this.menuItem9.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Path_Construct,
            this.Path_AddLines,
            this.Path_CloseFigure,
            this.Path_FillPath,
            this.Path_AddSubPath,
            this.Path_GetSubPath,
            this.Path_GetPoints,
            this.Path_PathData,
            this.Path_ViewPointFLAG,
            this.Path_SubPathRange,
            this.Path��Flatten,
            this.Path_Warp,
            this.Path_Transform,
            this.Path_Widen,
            this.Path_WidenDemo,
            this.Region��FromPath,
            this.Region_Calculate,
            this.Region_GetRects});
            this.menuItem9.Text = "·��������";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // Path_Construct
            // 
            this.Path_Construct.Index = 0;
            this.Path_Construct.Text = "����·��";
            this.Path_Construct.Click += new System.EventHandler(this.Path_Construct_Click);
            // 
            // Path_AddLines
            // 
            this.Path_AddLines.Index = 1;
            this.Path_AddLines.Text = "��·������Ӷ����߶�";
            this.Path_AddLines.Click += new System.EventHandler(this.Path_AddLines_Click);
            // 
            // Path_CloseFigure
            // 
            this.Path_CloseFigure.Index = 2;
            this.Path_CloseFigure.Text = "���ͼ��";
            this.Path_CloseFigure.Click += new System.EventHandler(this.Path_CloseFigure_Click);
            // 
            // Path_FillPath
            // 
            this.Path_FillPath.Index = 3;
            this.Path_FillPath.Text = "·�������";
            this.Path_FillPath.Click += new System.EventHandler(this.Path_FillPath_Click);
            // 
            // Path_AddSubPath
            // 
            this.Path_AddSubPath.Index = 4;
            this.Path_AddSubPath.Text = "�����·��";
            this.Path_AddSubPath.Click += new System.EventHandler(this.Path_AddSubPath_Click);
            // 
            // Path_GetSubPath
            // 
            this.Path_GetSubPath.Index = 5;
            this.Path_GetSubPath.Text = "GraphicsPathIterator�Ļ���ʹ��";
            this.Path_GetSubPath.Click += new System.EventHandler(this.Path_GetSubPath_Click);
            // 
            // Path_GetPoints
            // 
            this.Path_GetPoints.Index = 6;
            this.Path_GetPoints.Text = "����·���ĵ���Ϣ";
            this.Path_GetPoints.Click += new System.EventHandler(this.Path_GetPoints_Click);
            // 
            // Path_PathData
            // 
            this.Path_PathData.Index = 7;
            this.Path_PathData.Text = "ͬʱ��ȡ�˵����꼰������Ϣ";
            this.Path_PathData.Click += new System.EventHandler(this.Path_PathData_Click);
            // 
            // Path_ViewPointFLAG
            // 
            this.Path_ViewPointFLAG.Index = 8;
            this.Path_ViewPointFLAG.Text = "�鿴·���˵�ı����Ϣ";
            this.Path_ViewPointFLAG.Click += new System.EventHandler(this.Path_ViewPointFLAG_Click);
            // 
            // Path_SubPathRange
            // 
            this.Path_SubPathRange.Index = 9;
            this.Path_SubPathRange.Text = "���·������";
            this.Path_SubPathRange.Click += new System.EventHandler(this.Path_SubPathRange_Click);
            // 
            // Path��Flatten
            // 
            this.Path��Flatten.Index = 10;
            this.Path��Flatten.Text = "·����չƽ";
            this.Path��Flatten.Click += new System.EventHandler(this.Path��Flatten_Click);
            // 
            // Path_Warp
            // 
            this.Path_Warp.Index = 11;
            this.Path_Warp.Text = "·����Ť��";
            this.Path_Warp.Click += new System.EventHandler(this.Path_Warp_Click);
            // 
            // Path_Transform
            // 
            this.Path_Transform.Index = 12;
            this.Path_Transform.Text = "·�������Ա任";
            this.Path_Transform.Click += new System.EventHandler(this.Path_Transform_Click);
            // 
            // Path_Widen
            // 
            this.Path_Widen.Index = 13;
            this.Path_Widen.Text = "·�����ؿ�";
            this.Path_Widen.Click += new System.EventHandler(this.Path_Widen_Click);
            // 
            // Path_WidenDemo
            // 
            this.Path_WidenDemo.Index = 14;
            this.Path_WidenDemo.Text = "·�����ؿ���ԭ����ʾ";
            this.Path_WidenDemo.Click += new System.EventHandler(this.Path_WidenDemo_Click);
            // 
            // Region��FromPath
            // 
            this.Region��FromPath.Index = 15;
            this.Region��FromPath.Text = "��·���д����ı�����";
            this.Region��FromPath.Click += new System.EventHandler(this.Region��FromPath_Click);
            // 
            // Region_Calculate
            // 
            this.Region_Calculate.Index = 16;
            this.Region_Calculate.Text = "���������";
            this.Region_Calculate.Click += new System.EventHandler(this.Region_Calculate_Click);
            // 
            // Region_GetRects
            // 
            this.Region_GetRects.Index = 17;
            this.Region_GetRects.Text = "��ȡ�������ɾ��μ�";
            this.Region_GetRects.Click += new System.EventHandler(this.Region_GetRects_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 4;
            this.menuItem11.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Transform,
            this.TranslateTransform,
            this.RotateTransform,
            this.DrawWatch,
            this.ScaleTransform,
            this.RectScale,
            this.FontRotate,
            this.Matrix_ListElements,
            this.MatrixPos,
            this.Martrix_Invert,
            this.Matrix_Multiply,
            this.Matrix_TransformPoints,
            this.Matrix_TransformPoints2,
            this.Matrix_TransformVectors,
            this.Matrix_RotateAt,
            this.Matrix_Shear,
            this.Matrix_TextoutShear,
            this.Matrix_ChangeFontHeight});
            this.menuItem11.Text = "GDI+������任";
            // 
            // Transform
            // 
            this.Transform.Index = 0;
            this.Transform.Text = "��GDI+ʹ������任";
            this.Transform.Click += new System.EventHandler(this.Transform_Click);
            // 
            // TranslateTransform
            // 
            this.TranslateTransform.Index = 1;
            this.TranslateTransform.Text = "ƽ�Ʊ任��ʵ��";
            this.TranslateTransform.Click += new System.EventHandler(this.TranslateTransform_Click);
            // 
            // RotateTransform
            // 
            this.RotateTransform.Index = 2;
            this.RotateTransform.Text = "��תͼƬ";
            this.RotateTransform.Click += new System.EventHandler(this.RotateTransform_Click);
            // 
            // DrawWatch
            // 
            this.DrawWatch.Index = 3;
            this.DrawWatch.Text = "������̱�Ļ���";
            this.DrawWatch.Click += new System.EventHandler(this.DrawWatch_Click);
            // 
            // ScaleTransform
            // 
            this.ScaleTransform.Index = 4;
            this.ScaleTransform.Text = "���ű任��ʹ��";
            this.ScaleTransform.Click += new System.EventHandler(this.ScaleTransform_Click);
            // 
            // RectScale
            // 
            this.RectScale.Index = 5;
            this.RectScale.Text = "���ζ��������";
            this.RectScale.Click += new System.EventHandler(this.RectScale_Click);
            // 
            // FontRotate
            // 
            this.FontRotate.Index = 6;
            this.FontRotate.Text = "��GDI+����ת����ı�";
            this.FontRotate.Click += new System.EventHandler(this.FontRotate_Click);
            // 
            // Matrix_ListElements
            // 
            this.Matrix_ListElements.Index = 7;
            this.Matrix_ListElements.Text = "�鿴��������Ԫ��";
            this.Matrix_ListElements.Click += new System.EventHandler(this.Matrix_ListElements_Click_1);
            // 
            // MatrixPos
            // 
            this.MatrixPos.Index = 8;
            this.MatrixPos.Text = "ʹ�þ����ǰ�����׺";
            this.MatrixPos.Click += new System.EventHandler(this.MatrixPos_Click);
            // 
            // Martrix_Invert
            // 
            this.Martrix_Invert.Index = 9;
            this.Martrix_Invert.Text = "������ڱ任�е�����";
            this.Martrix_Invert.Click += new System.EventHandler(this.Martrix_Invert_Click);
            // 
            // Matrix_Multiply
            // 
            this.Matrix_Multiply.Index = 10;
            this.Matrix_Multiply.Text = "ʹ�ø��ϱ任";
            this.Matrix_Multiply.Click += new System.EventHandler(this.Matrix_Multiply_Click);
            // 
            // Matrix_TransformPoints
            // 
            this.Matrix_TransformPoints.Index = 11;
            this.Matrix_TransformPoints.Text = "ʹ�þ��������޸ĵ���Ϣ\r\n \r\n";
            this.Matrix_TransformPoints.Click += new System.EventHandler(this.Matrix_TransformPoints_Click);
            // 
            // Matrix_TransformPoints2
            // 
            this.Matrix_TransformPoints2.Index = 12;
            this.Matrix_TransformPoints2.Text = "ʹ��TransformPoints����ʵ��·���ı任\r\n \r\n";
            this.Matrix_TransformPoints2.Click += new System.EventHandler(this.Matrix_TransformPoints2_Click);
            // 
            // Matrix_TransformVectors
            // 
            this.Matrix_TransformVectors.Index = 13;
            this.Matrix_TransformVectors.Text = "��ͨ�����������ά�����ľ�������";
            this.Matrix_TransformVectors.Click += new System.EventHandler(this.Matrix_TransformVectors_Click);
            // 
            // Matrix_RotateAt
            // 
            this.Matrix_RotateAt.Index = 14;
            this.Matrix_RotateAt.Text = "ʹ��RotateAt����";
            this.Matrix_RotateAt.Click += new System.EventHandler(this.Matrix_RotateAt_Click);
            // 
            // Matrix_Shear
            // 
            this.Matrix_Shear.Index = 15;
            this.Matrix_Shear.Text = "ʹ�ò�ͬ��Ͷ��任��ʾͼƬ";
            this.Matrix_Shear.Click += new System.EventHandler(this.Matrix_Shear_Click);
            // 
            // Matrix_TextoutShear
            // 
            this.Matrix_TextoutShear.Index = 16;
            this.Matrix_TextoutShear.Text = "ͶӰ�ֵ���Ч���";
            this.Matrix_TextoutShear.Click += new System.EventHandler(this.Matrix_TextoutShear_Click);
            // 
            // Matrix_ChangeFontHeight
            // 
            this.Matrix_ChangeFontHeight.Index = 17;
            this.Matrix_ChangeFontHeight.Text = "���ִ�С���������Ч";
            this.Matrix_ChangeFontHeight.Click += new System.EventHandler(this.Matrix_ChangeFontHeight_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 5;
            this.menuItem12.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ColorMatrix��Start,
            this.TranslateColor,
            this.ScaleColor,
            this.RotateColor,
            this.ColorShear,
            this.ColorRemap,
            this.SetRGBOutputChannel});
            this.menuItem12.Text = "GDI+��ɫ�ʱ任";
            // 
            // ColorMatrix��Start
            // 
            this.ColorMatrix��Start.Index = 0;
            this.ColorMatrix��Start.Text = "����ɫ�ʱ任����";
            this.ColorMatrix��Start.Click += new System.EventHandler(this.ColorMatrix��Start_Click);
            // 
            // TranslateColor
            // 
            this.TranslateColor.Index = 1;
            this.TranslateColor.Text = "ɫ��ƽ������";
            this.TranslateColor.Click += new System.EventHandler(this.TranslateColor_Click);
            // 
            // ScaleColor
            // 
            this.ScaleColor.Index = 2;
            this.ScaleColor.Text = "ɫ�ʵ���������";
            this.ScaleColor.Click += new System.EventHandler(this.ScaleColor_Click);
            // 
            // RotateColor
            // 
            this.RotateColor.Index = 3;
            this.RotateColor.Text = "ɫ�ʵ�������ת��ʽ";
            this.RotateColor.Click += new System.EventHandler(this.RotateColor_Click);
            // 
            // ColorShear
            // 
            this.ColorShear.Index = 4;
            this.ColorShear.Text = "ɫ�ʵ�Ͷ��任";
            this.ColorShear.Click += new System.EventHandler(this.ColorShear_Click);
            // 
            // ColorRemap
            // 
            this.ColorRemap.Index = 5;
            this.ColorRemap.Text = "ɫ��ӳ��ĳ���ʵ��";
            this.ColorRemap.Click += new System.EventHandler(this.ColorRemap_Click);
            // 
            // SetRGBOutputChannel
            // 
            this.SetRGBOutputChannel.Index = 6;
            this.SetRGBOutputChannel.Text = "ʹ��ɫ�ʱ任����ʵ��ɫ�����ͨ��";
            this.SetRGBOutputChannel.Click += new System.EventHandler(this.SetRGBOutputChannel_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 6;
            this.menuItem13.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Metafile,
            this.CroppingAndScaling,
            this.UsingInterpolationMode,
            this.RotateFlip,
            this.ImageSkewing,
            this.Cubeimage,
            this.ThumbnailImage,
            this.Clone,
            this.Picturescale});
            this.menuItem13.Text = "ͼ��Ļ�������";
            // 
            // Metafile
            // 
            this.Metafile.Index = 0;
            this.Metafile.Text = "ͼԪ�ļ��еļ�¼��ط�";
            this.Metafile.Click += new System.EventHandler(this.Metafile_Click);
            // 
            // CroppingAndScaling
            // 
            this.CroppingAndScaling.Index = 1;
            this.CroppingAndScaling.Text = "ͼ�εļ���������";
            this.CroppingAndScaling.Click += new System.EventHandler(this.CroppingAndScaling_Click);
            // 
            // UsingInterpolationMode
            // 
            this.UsingInterpolationMode.Index = 2;
            this.UsingInterpolationMode.Text = "ʹ�ò�ͬ�Ĳ�ֵģʽ����ͼ����������";
            this.UsingInterpolationMode.Click += new System.EventHandler(this.UsingInterpolationMode_Click);
            // 
            // RotateFlip
            // 
            this.RotateFlip.Index = 3;
            this.RotateFlip.Text = "���ƾ���ͼƬʾ��";
            this.RotateFlip.Click += new System.EventHandler(this.RotateFlip_Click);
            // 
            // ImageSkewing
            // 
            this.ImageSkewing.Index = 4;
            this.ImageSkewing.Text = "����ӳ��ͼƬ";
            this.ImageSkewing.Click += new System.EventHandler(this.ImageSkewing_Click);
            // 
            // Cubeimage
            // 
            this.Cubeimage.Index = 5;
            this.Cubeimage.Text = "��������ͼ";
            this.Cubeimage.Click += new System.EventHandler(this.Cubeimage_Click);
            // 
            // ThumbnailImage
            // 
            this.ThumbnailImage.Index = 6;
            this.ThumbnailImage.Text = "GDI+�д�������ͼ";
            this.ThumbnailImage.Click += new System.EventHandler(this.ThumbnailImage_Click);
            // 
            // Clone
            // 
            this.Clone.Index = 7;
            this.Clone.Text = "�ֿ���ʾͼƬ";
            this.Clone.Click += new System.EventHandler(this.Clone_Click);
            // 
            // Picturescale
            // 
            this.Picturescale.Index = 8;
            this.Picturescale.Text = "ͼƬ�ֲ��Ŵ�(��С)��ʾ";
            this.Picturescale.Click += new System.EventHandler(this.Picturescale_Click);
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 7;
            this.menuItem15.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ImageAttributesSetNoOp,
            this.SetColorMatrices,
            this.SetOutputChannelColorProfile,
            this.Gammaadjust,
            this.SetOutputChannel,
            this.Colorkey,
            this.Setthreshold,
            this.AdjustedPalette,
            this.SetWrapMode});
            this.menuItem15.Text = "ͼ��ɫ����Ϣ�ĵ���";
            // 
            // ImageAttributesSetNoOp
            // 
            this.ImageAttributesSetNoOp.Index = 0;
            this.ImageAttributesSetNoOp.Text = "ɫ��У�������������";
            this.ImageAttributesSetNoOp.Click += new System.EventHandler(this.ImageAttributesSetNoOp_Click);
            // 
            // SetColorMatrices
            // 
            this.SetColorMatrices.Index = 1;
            this.SetColorMatrices.Text = "���ò�ͬ��ɫ�ʵ�������";
            this.SetColorMatrices.Click += new System.EventHandler(this.SetColorMatrices_Click);
            // 
            // SetOutputChannelColorProfile
            // 
            this.SetOutputChannelColorProfile.Index = 2;
            this.SetOutputChannelColorProfile.Text = "ʹ��ɫ�������ļ�����ɫ��У��";
            this.SetOutputChannelColorProfile.Click += new System.EventHandler(this.SetOutputChannelColorProfile_Click);
            // 
            // Gammaadjust
            // 
            this.Gammaadjust.Index = 3;
            this.Gammaadjust.Text = "�޸�Gammaֵ����ͼƬ���";
            this.Gammaadjust.Click += new System.EventHandler(this.Gammaadjust_Click);
            // 
            // SetOutputChannel
            // 
            this.SetOutputChannel.Index = 4;
            this.SetOutputChannel.Text = "����ɫ�����ͨ��";
            this.SetOutputChannel.Click += new System.EventHandler(this.SetOutputChannel_Click);
            // 
            // Colorkey
            // 
            this.Colorkey.Index = 5;
            this.Colorkey.Text = "ʹ�ùؼ�ɫ";
            this.Colorkey.Click += new System.EventHandler(this.Colorkey_Click);
            // 
            // Setthreshold
            // 
            this.Setthreshold.Index = 6;
            this.Setthreshold.Text = "��ֵ������ʾ����";
            this.Setthreshold.Click += new System.EventHandler(this.Setthreshold_Click);
            // 
            // AdjustedPalette
            // 
            this.AdjustedPalette.Index = 7;
            this.AdjustedPalette.Text = "��ȡɫ��У����ɫ��";
            this.AdjustedPalette.Click += new System.EventHandler(this.AdjustedPalette_Click);
            // 
            // SetWrapMode
            // 
            this.SetWrapMode.Index = 8;
            this.SetWrapMode.Text = "����ɫ��У���Ļ���ģʽ����ɫ";
            this.SetWrapMode.Click += new System.EventHandler(this.SetWrapMode_Click);
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 8;
            this.menuItem16.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ListAllImageEncoders,
            this.ListImageEncoder_Detail,
            this.ListImageDecoder,
            this.GetEncoderParameter,
            this.GetAllEncoderParameter,
            this.menuItem17,
            this.SaveBmp2tif,
            this.SaveBMP2JPG,
            this.TransformingJPEG,
            this.MultipleFrameImage,
            this.GetImageFromMultyFrame,
            this.QueryImage,
            this.SetProp});
            this.menuItem16.Text = "ͼ�εı��������";
            // 
            // ListAllImageEncoders
            // 
            this.ListAllImageEncoders.Index = 0;
            this.ListAllImageEncoders.Text = "�����������Ϣ";
            this.ListAllImageEncoders.Click += new System.EventHandler(this.ListAllImageEncoders_Click);
            // 
            // ListImageEncoder_Detail
            // 
            this.ListImageEncoder_Detail.Index = 1;
            this.ListImageEncoder_Detail.Text = "�����������Ϣ";
            this.ListImageEncoder_Detail.Click += new System.EventHandler(this.ListImageEncoder_Detail_Click);
            // 
            // ListImageDecoder
            // 
            this.ListImageDecoder.Index = 2;
            this.ListImageDecoder.Text = "�г�ϵͳ���õĽ�������Ϣ";
            this.ListImageDecoder.Click += new System.EventHandler(this.ListImageDecoder_Click);
            // 
            // GetEncoderParameter
            // 
            this.GetEncoderParameter.Index = 3;
            this.GetEncoderParameter.Text = "�鿴��λͼ����ΪJPEGʱ��Ҫ���õĲ�����Ϣ";
            this.GetEncoderParameter.Click += new System.EventHandler(this.GetEncoderParameter_Click);
            // 
            // GetAllEncoderParameter
            // 
            this.GetAllEncoderParameter.Index = 4;
            this.GetAllEncoderParameter.Text = "�鿴���еı�����Ϣ����Ĳ����б�";
            this.GetAllEncoderParameter.Click += new System.EventHandler(this.GetAllEncoderParameter_Click);
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 5;
            this.menuItem17.Text = "��BMP�ļ����ΪPNG��ʽ���ļ�";
            this.menuItem17.Click += new System.EventHandler(this.menuItem17_Click);
            // 
            // SaveBmp2tif
            // 
            this.SaveBmp2tif.Index = 6;
            this.SaveBmp2tif.Text = "��BMP�ļ�����ΪTIF�ļ�";
            this.SaveBmp2tif.Click += new System.EventHandler(this.SaveBmp2tif_Click);
            // 
            // SaveBMP2JPG
            // 
            this.SaveBMP2JPG.Index = 7;
            this.SaveBMP2JPG.Text = "ʹ�ò�ͬ��ѹ����������JPEG�ļ�";
            this.SaveBMP2JPG.Click += new System.EventHandler(this.SaveBMP2JPG_Click);
            // 
            // TransformingJPEG
            // 
            this.TransformingJPEG.Index = 8;
            this.TransformingJPEG.Text = "JPEG�ļ��ı�����任";
            this.TransformingJPEG.Click += new System.EventHandler(this.TransformingJPEG_Click);
            // 
            // MultipleFrameImage
            // 
            this.MultipleFrameImage.Index = 9;
            this.MultipleFrameImage.Text = "�����֡ͼƬ";
            this.MultipleFrameImage.Click += new System.EventHandler(this.MultipleFrameImage_Click);
            // 
            // GetImageFromMultyFrame
            // 
            this.GetImageFromMultyFrame.Index = 10;
            this.GetImageFromMultyFrame.Text = "��ȡ��֡ͼƬ����ͼƬ";
            this.GetImageFromMultyFrame.Click += new System.EventHandler(this.GetImageFromMultyFrame_Click);
            // 
            // QueryImage
            // 
            this.QueryImage.Index = 11;
            this.QueryImage.Text = "��ȡͼ�������б�";
            this.QueryImage.Click += new System.EventHandler(this.QueryImage_Click);
            // 
            // SetProp
            // 
            this.SetProp.Index = 12;
            this.SetProp.Text = "�޸�ͼƬ����";
            this.SetProp.Click += new System.EventHandler(this.SetProp_Click);
            // 
            // menuItem18
            // 
            this.menuItem18.Index = 9;
            this.menuItem18.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FadeInOut,
            this.GrayScale,
            this.Inverse,
            this.Emboss,
            this.OnCanvas,
            this.OnWood,
            this.Flashligt,
            this.BlurAndSharpen});
            this.menuItem18.Text = "ͼ���ؼ�����";
            // 
            // FadeInOut
            // 
            this.FadeInOut.Index = 0;
            this.FadeInOut.Text = "����ǳ��";
            this.FadeInOut.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // GrayScale
            // 
            this.GrayScale.Index = 1;
            this.GrayScale.Text = "�Ҷȴ����뻹ԭ";
            this.GrayScale.Click += new System.EventHandler(this.GrayScale_Click);
            // 
            // Inverse
            // 
            this.Inverse.Index = 2;
            this.Inverse.Text = "��Ƭ(��Ƭ)�˾�";
            this.Inverse.Click += new System.EventHandler(this.Inverse_Click);
            // 
            // Emboss
            // 
            this.Emboss.Index = 3;
            this.Emboss.Text = "���񼰵��";
            this.Emboss.Click += new System.EventHandler(this.Emboss_Click);
            // 
            // OnCanvas
            // 
            this.OnCanvas.Index = 4;
            this.OnCanvas.Text = "�ͻ�Ч��������";
            this.OnCanvas.Click += new System.EventHandler(this.OnCanvas_Click);
            // 
            // OnWood
            // 
            this.OnWood.Index = 5;
            this.OnWood.Text = "ľ���˾�";
            this.OnWood.Click += new System.EventHandler(this.OnWood_Click);
            // 
            // Flashligt
            // 
            this.Flashligt.Index = 6;
            this.Flashligt.Text = "ǿ�������˾�";
            this.Flashligt.Click += new System.EventHandler(this.Flashligt_Click);
            // 
            // BlurAndSharpen
            // 
            this.BlurAndSharpen.Index = 7;
            this.BlurAndSharpen.Text = "�ữ�����˾�";
            this.BlurAndSharpen.Click += new System.EventHandler(this.BlurAndSharpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(560, 313);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "GDIPlusDemo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// Ӧ�ó��������ڵ㡣
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());

        }

        private void menuItem2_Click(object sender, System.EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);
            Bitmap bitmap = new Bitmap("demo.bmp");
            int iWidth = bitmap.Width;
            int iHeight = bitmap.Height;

            //��ʼ��ɫ�ʱ任����
            float[][] tem =
		{
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 1.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 1.0f}
		};

            ColorMatrix colorMatrix = new ColorMatrix(tem);
            ImageAttributes imageAtt = new ImageAttributes();

            //��0��1�����޸�ɫ�ʱ任�������Խ����ϵ���ֵ
            //ʹ���ֻ�׼ɫ�ı��ͶȽ���
            for (float i = 0.0f; i <= 1.0f; i += 0.02f)
            {
                colorMatrix.Matrix00 = i;
                colorMatrix.Matrix11 = i;
                colorMatrix.Matrix22 = i;
                colorMatrix.Matrix33 = i;
                //����ɫ��У������
                imageAtt.SetColorMatrix(colorMatrix,
                    ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                //����ͼƬ
                g.DrawImage(
                    bitmap, new Rectangle(0, 0, iWidth, iHeight),
                    0, 0,
                    iWidth, iHeight,
                    GraphicsUnit.Pixel,
                    imageAtt);
            }

            MessageBox.Show("������ʾ����Ч��");

            //��1��0�����޸�ɫ�ʱ任�������Խ����ϵ���ֵ
            //���μ���ÿ��ɫ�ʷ���
            for (float i = 1.0f; i >= 0.0f; i -= 0.02f)
            {
                colorMatrix.Matrix00 = i;
                colorMatrix.Matrix11 = i;
                colorMatrix.Matrix22 = i;
                colorMatrix.Matrix33 = i;
                //����ɫ��У������
                imageAtt.SetColorMatrix(colorMatrix,
                    ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                //����ͼƬ
                g.DrawImage(
                    bitmap, new Rectangle(0, 0, iWidth, iHeight),
                    0, 0,
                    iWidth, iHeight,
                    GraphicsUnit.Pixel,
                    imageAtt);
            }
        }


        private void GrayScale_Click(object sender, System.EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            Bitmap image = new Bitmap("head.bmp");
            int Width = image.Width - 1;
            int Height = image.Height - 1;

            //����ԭͼ
            g.DrawImage(image, 0, 0);
            g.TranslateTransform(image.Width, 0);

            /*image2��image3�ֱ������������ֵ��
            �ͼ�Ȩƽ��������ĻҶ�ͼ��*/
            Bitmap image2 = image.Clone(new Rectangle(0, 0, image.Width,
                image.Height), PixelFormat.DontCare);
            Bitmap image3 = image.Clone(new Rectangle(0, 0, image.Width,
                image.Height), PixelFormat.DontCare);

            Color color;
            //ʹ��ƽ��ֵ���лҶȴ���
            for (int i = Width; i >= 0; i--)
                for (int j = Height; j >= 0; j--)
                {
                    color = image.GetPixel(i, j);
                    //���ƽ������ɫ�ʷ�����ƽ��ֵ
                    int middle = (color.R +
                        color.G + color.B) / 3;
                    Color colorResult = Color.FromArgb(255, middle, middle, middle);
                    image.SetPixel(i, j, colorResult);
                }
            //���»��ƻҶȻ�ͼ
            g.DrawImage(
                image, new Rectangle(0, 0, Width, Height));

            //����λ����ʾ���ֵ�����лҶȴ���Ľ��
            g.TranslateTransform(image.Width, 0);
            //ʹ�����ֵ�����лҶȴ���
            for (int i = Width; i >= 0; i--)
            {
                for (int j = Height; j >= 0; j--)
                {
                    color = image2.GetPixel(i, j);
                    int tmp = Math.Max(color.R, color.G);
                    int maxcolor = Math.Max(tmp, color.B);
                    Color colorResult = Color.FromArgb(255, maxcolor, maxcolor, maxcolor);
                    //���ô����ĻҶ���Ϣ
                    image2.SetPixel(i, j, colorResult);
                }
            }

            //���»��ƻҶȻ�ͼ
            g.DrawImage(
                image2, new Rectangle(0, 0, Width, Height));
            //�ڵڶ��л���ͼƬ
            g.ResetTransform();
            g.TranslateTransform(0, image.Height);

            //ʹ�ü�Ȩƽ�������лҶȴ���	
            for (int i = Width; i >= 0; i--)
            {
                for (int j = Height; j >= 0; j--)
                {
                    color = image3.GetPixel(i, j);
                    int R = (int)(0.3f * color.R);
                    int G = (int)(0.59f * color.G);
                    int B = (int)(0.11f * color.B);

                    Color colorResult = Color.FromArgb(255, R, G, B);
                    //���ô����ĻҶ���Ϣ
                    image3.SetPixel(i, j, colorResult);
                }
            }
            //���»��ƻҶȻ�ͼ
            g.DrawImage(
                image3, new Rectangle(0, 0, Width, Height));

            g.TranslateTransform(image.Width, 0);
            //�ҶȵĻ�ԭ��ʾ����ԭʹ�����ֵ������ĻҶ�ͼ��image2
            for (int i = Width; i > 0; i--)
            {
                for (int j = Height; j > 0; j--)
                {
                    color = image2.GetPixel(i, j);
                    int R = color.R;
                    int G = color.G;
                    int B = color.B;
                    //�ֱ��RGB����ɫ�ʷ�������α��ɫ��ԭ

                    //���к�ɫ�����Ļ�ԭ
                    if (R < 127)
                        R = 0;
                    if (R >= 192)
                        R = 255;
                    if (R <= 191 && R >= 128)
                        R = 4 * R - 510;

                    /*������ɫ�����Ļ�ԭ,Ϊ�˻�ԭ�����ɫ�����ٴβμӱȽϣ�
                    ��������һ������YES��ʾG�Ƿ��Ѿ��μ��˱Ƚ�*/

                    bool yes;
                    yes = false;
                    if (G <= 191 && G >= 128 && (!yes))
                    {
                        G = 255;
                        yes = true;
                    }
                    if (G >= 192 && (!yes))
                    {
                        G = 1022 - 4 * G;
                        yes = true;
                    }
                    if (G <= 63 && (!yes))
                    {
                        G = 254 - 4 * G;
                        yes = true;
                    }
                    if (G <= 127 && G >= 67 && (!yes))
                        G = 4 * G - 257;

                    //������ɫ�����Ļ�ԭ
                    if (B <= 63)
                        B = 255;
                    if (B >= 128)
                        B = 0;
                    if (B >= 67 && B <= 127)
                        B = 510 - 4 * B;

                    //��ԭ���α��ɫ
                    Color colorResult = Color.FromArgb(255, R, G, B);
                    //����ԭ���RGB��Ϣ����д��λͼ
                    image2.SetPixel(i, j, colorResult);

                }
            }
            //���»��ƻ�ԭ���α��ɫλͼ
            //���»��ƻҶȻ�ͼ
            g.DrawImage(
                image2, new Rectangle(0, 0, Width, Height));
        }

        private void Inverse_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            graphics.ScaleTransform(0.7f, 0.7f);

            Bitmap image = new Bitmap("head.bmp");
            int Width = image.Width;
            int Height = image.Height;

            Color colorTemp, color2;
            Color color;
            //����ԭͼ
            graphics.DrawImage(
                image, new Rectangle(0, 0, Width, Height));

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    color = image.GetPixel(i, j);
                    //��ɫ�ʽ��з�ת����õ�ƬЧ��
                    int r = 255 - color.R;
                    int g = 255 - color.G;
                    int b = 255 - color.B;
                    Color colorResult = Color.FromArgb(255, r, g, b);
                    //����ԭ���RGB��Ϣ����д��λͼ
                    image.SetPixel(i, j, colorResult);
                }
                //��̬���Ƶ�Ƭ�˾�Ч��ͼ
                graphics.DrawImage(
                    image, new Rectangle(Width, 0, Width, Height));
            }
            //���Ѿ�ʵ���˵�ƬЧ����λͼ�ٷ�ɫ(�ָ���ԭͼ)
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    color = image.GetPixel(i, j);
                    int r = 255 - color.R;
                    int g = 255 - color.G;
                    int b = 255 - color.B;
                    Color colorResult = Color.FromArgb(255, r, g, b);
                    //����ԭ���RGB��Ϣ����д��λͼ
                    image.SetPixel(i, j, colorResult);
                }
                //���ƾ������η�ɫ��λͼ
                graphics.DrawImage(
                    image, new Rectangle(Width * 2, 0, Width, Height));
            }

        }

        private void Emboss_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            graphics.ScaleTransform(0.7f, 0.7f);

            Bitmap image = new Bitmap("head.bmp");
            int Width = image.Width;
            int Height = image.Height;

            //image2:���е�̴���
            Bitmap image2 = image.Clone(new Rectangle(0, 0, Width, Height), PixelFormat.DontCare);

            //����ԭͼ
            graphics.DrawImage(
                image, new Rectangle(0, 0, Width, Height));
            Color color, colorTemp, colorLeft;

            //����ͼƬ�ĸ�����
            //���η���ÿ�����ص�RGBֵ
            for (int i = Width - 1; i > 0; i--)
            {
                for (int j = Height - 1; j > 0; j--)
                {
                    //��ȡ�����������ص�R��G��Bֵ
                    color = image.GetPixel(i, j);
                    colorLeft = image.GetPixel(i - 1, j - 1);
                    //���������Ͻ����ص�RGB����֮��
                    //67������ͼƬ����ͻҶȣ�128������������������ֵ��õ���ͬ��Ч��
                    int r = Math.Max(67, Math.Min(255,
                        Math.Abs(color.R - colorLeft.R + 128)));
                    int g = Math.Max(67, Math.Min(255,
                        Math.Abs(color.G - colorLeft.G + 128)));
                    int b = Math.Max(67, Math.Min(255,
                        Math.Abs(color.B - colorLeft.B + 128)));
                    Color colorResult = Color.FromArgb(255, r, g, b);
                    //��������RGBֵ��д��λͼ
                    image.SetPixel(i, j, colorResult);
                }

                //���Ƹ���ͼ
                graphics.DrawImage(
                    image, new Rectangle(Width + 10, 0, Width, Height));
            }

            //����ͼƬ�ĵ�̴���
            for (int i = 0; i < Height - 1; i++)
            {
                for (int j = 0; j < Width - 1; j++)
                {
                    color = image2.GetPixel(j, i);
                    colorLeft = image2.GetPixel(j + 1, i + 1);
                    //���������½����صķ���֮��
                    //67������ͼƬ����ͻҶȣ�128������������������ֵ��õ���ͬ��Ч��
                    int r = Math.Max(67, Math.Min(255,
                        Math.Abs(color.R - colorLeft.R + 128)));
                    int g = Math.Max(67, Math.Min(255,
                        Math.Abs(color.G - colorLeft.G + 128)));
                    int b = Math.Max(67, Math.Min(255,
                        Math.Abs(color.B - colorLeft.B + 128)));
                    Color colorResult = Color.FromArgb(255, r, g, b);
                    image2.SetPixel(j, i, colorResult);
                }

                //���Ƶ��ͼ
                graphics.DrawImage(
                    image2, new Rectangle(Width * 2 + 20, 0, Width, image.Height));
            }
        }

        private void CreatePenFromBrush_Click(object sender, System.EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            //�������Խ��仭ˢ
            LinearGradientBrush LineargradientBrush
                = new LinearGradientBrush(new Rectangle(0, 0, 10, 10),
                Color.Blue, Color.Red, LinearGradientMode.BackwardDiagonal);
            //�����Խ��仭ˢ�й��컭��
            Pen pen = new Pen(LineargradientBrush);
            pen.Width = 10;
            //���ƾ���
            g.DrawRectangle(pen, 10, 10, 100, 100);

            //װ������ͼƬ
            Bitmap image = new Bitmap("butterfly.bmp");
            //��������ˢ
            TextureBrush tBrush = new TextureBrush(image);
            //����ˢ���뻭�ʵĹ��캯��
            Pen texturedPen = new Pen(tBrush, 42);

            //���ñ��������ߵ���ֹ�㼰���Ƶ�
            Point p1 = new Point(10, 100);
            Point c1 = new Point(100, 10);
            Point c2 = new Point(150, 150);
            Point p2 = new Point(200, 100);
            g.TranslateTransform(130, 0);
            //���Ʊ���������
            g.DrawBezier(texturedPen, p1, c1, c2, p2);
        }

        //���ʵ�������ʾ
        private void DashStyle_Custom_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 5);

            //�����ı�������뷽ʽ������
            StringFormat fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Near;
            fmt.LineAlignment = StringAlignment.Center;
            //����
            Font font = new Font("Arial", 12);
            SolidBrush sBrush = new SolidBrush(Color.Black);
            graphics.TranslateTransform(0, 30);

            int i = 0;
            //�ֱ�ʹ�ó������������ͻ���ֱ��
            for (; i < 5; i++)
            {
                //��������
                pen.DashStyle = (DashStyle)i;
                graphics.DrawLine(pen, 10, 30 * i, 260, 30 * i);
                //�����ǰ���͵�����
                graphics.DrawString(pen.DashStyle.ToString(),
                    font, sBrush, new Point(260, 30 * i), fmt);
            }

            //ʹ���Զ���������
            float[] dashVals =	{
									5.0f,   // �߳�5������
									2.0f,   // ���2������
									15.0f,  // �߳�15������
									4.0f    // ���4������
								};
            pen.DashPattern = dashVals;
            pen.Color = (Color.Red);
            graphics.DrawLine(pen, 10, 30 * i, 260, 30 * i);
            graphics.DrawString(pen.DashStyle.ToString(), font, sBrush, new Point(260, 30 * i), fmt);
        }

        private void Pen_Align_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);


            Pen pen = new Pen(Color.Gray, 1.0f);


            Pen pen2 = new Pen(Color.FromArgb(155, Color.Red), 10);
            int i = 0;
            for (; i < 5; i++)
            {
                pen2.Alignment = (PenAlignment)i;
                graphics.DrawLine(pen2, new Point(0, 10), new Point(60, 10));
                graphics.TranslateTransform(70, 0);

            }

            graphics.ResetTransform();
            graphics.DrawLine(pen, 0, 10, 600, 10);


        }

        private void Pen_Tranform_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //����һ֧���Ϊ5�ĺ�ɫ����
            Pen pen = new Pen(Color.Red, 3.0f);
            //�����ʴӴ�ֱ��������6����ˮƽ���򱣳ֲ���
            pen.ScaleTransform(1, 6);
            //ʹ��δ����ת����Ļ��ʻ�Բ
            graphics.DrawEllipse(pen, 0, 50, 80, 80);
            //60����ת
            graphics.TranslateTransform(100, 0);
            pen.RotateTransform(60, MatrixOrder.Append);
            graphics.DrawEllipse(pen, 0, 50, 80, 80);
            //120����ת
            graphics.TranslateTransform(100, 0);
            pen.RotateTransform(60, MatrixOrder.Append);
            graphics.DrawEllipse(pen, 0, 50, 80, 80);
            //180����ת
            graphics.TranslateTransform(100, 0);
            pen.RotateTransform(60, MatrixOrder.Append);
            graphics.DrawEllipse(pen, 0, 50, 80, 80);
        }
        //��ñ��ʾ
        private void Pen_LineCap_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //�����ı�������뷽ʽ������
            StringFormat fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Near;
            fmt.LineAlignment = StringAlignment.Center;
            //����
            Font font = new Font("Arial", 12);
            SolidBrush sBrush = new SolidBrush(Color.Black);

            //�������Ϊ15�Ļ���
            Pen pen = new Pen(Color.Black, 15);
            //�ֱ�ʹ�ò�ͬ����ñ
            foreach (LineCap lincap in Enum.GetValues(typeof(LineCap)))
            {
                pen.StartCap = lincap;//���
                pen.EndCap = lincap;//�յ�

                graphics.DrawLine(pen, 50, 10, 300, 10);
                //�����ǰ��ñ���ͣ�LineCapö�ٳ�Ա����
                graphics.DrawString(pen.StartCap.ToString(),
                    font, sBrush, new Point(320, 10), fmt);
                //ƽ�ƻ�ͼƽ��
                graphics.TranslateTransform(0, 30);
            }
        }

        //���ʵ�͸����֧��
        private void Pen_TransColor_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //�ֱ�����ɫ����ɫ����
            Pen blue = new Pen(Color.Blue);
            Pen red = new Pen(Color.Red);
            //��������
            int y = 256;
            for (int x = 0; x < 256; x += 5)
            {
                graphics.DrawLine(blue, 0, y, x, 0);
                graphics.DrawLine(red, 256, x, y, 256);
                y -= 5;
                //��ʱ�Բ鿴��̬Ч��
                Thread.Sleep(20);
            }
            //ʹ����ɫ���ʻ��Ʋ�ͬ͸���ȵ�����
            //͸�������ϵ������εݼ�
            for (y = 0; y < 256; y++)
            {
                Pen pen = new Pen(Color.FromArgb(y, Color.Green));
                graphics.DrawLine(pen, 0, y, 256, y);
                //��ʱ�Ա�鿴��̬Ч��
                Thread.Sleep(20);
            }

            //ʹ����ɫ���ʻ��Ʋ�ͬ͸���ȵ�����
            //͸�������������εݼ�
            for (int x = 0; x < 256; x++)
            {
                Pen pen = new Pen(Color.FromArgb(x, Color.Blue));
                graphics.DrawLine(pen, x, 100, x, 200);
                //��ʱ�Բ鿴��̬Ч��
                Thread.Sleep(20);
            }
        }
        //�򵥵ĵ�ɫ��ˢʾ��
        private void Brush_SolidBrush_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //������ɫ��ˢ
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            //�������ߡ�����ζ˵�����
            PointF point1 = new PointF(100.0f, 100.0f);
            PointF point2 = new PointF(200.0f, 50.0f);
            PointF point3 = new PointF(250.0f, 200.0f);
            PointF point4 = new PointF(50.0f, 150.0f);
            PointF point5 = new PointF(100.0f, 100.0f);
            PointF[] points = new PointF[] { point1, point2, point3, point4 };
            //���պ�����
            graphics.FillClosedCurve(greenBrush, points, FillMode.Alternate, 1.0f);

            //��������(�պ�)
            PointF[] poly = new PointF[] { point1, point2, point3, point4, point5 };
            //����һ��λ���������
            graphics.TranslateTransform(300, 0);
            graphics.FillPolygon(greenBrush, poly, FillMode.Alternate);
        }
        //�����Ҷ����
        private void Brush_FillVurve_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //������ɫ��ˢ
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            int cx, cy;
            //�Ե�ǰ���ڵ����ĵ������Ҷ����
            cx = this.Width / 2;
            cy = this.Height / 2;
            //����"Ҷ"��
            int LeafLength = 80;
            //����ҶƬ����=2* LeafNum
            int LeafNum = 5;
            double x, y, x2, y2, r;

            //����һ��ͼ��·����������������Ҷ���ߵı߽���
            GraphicsPath tmpPath = new GraphicsPath(FillMode.Alternate);
            //�������߽߱����ݣ��Ƕȱ仯Ϊһ��PI*2
            for (float i = 0.0f; i < Math.PI * 2 + 0.1f; i += (float)Math.PI / 180)
            {
                r = (int)Math.Abs(LeafLength * Math.Cos(LeafNum * i));
                x = r * Math.Cos(i);
                y = r * Math.Sin(i);
                x2 = cx + x;
                y2 = cy + y;
                /*�����ߵı߽���Ϣ������ʱ·��,�����Ҫ�鿴��Щ��Ϣ�����ɵ�����
                �������ڴ˼���graphics.DrawLine(&pen,x2,y2,x2-1,y2-1);*/
                tmpPath.AddLine((int)x2, (int)y2, (int)x2, (int)y2);
            }

            //���·��
            graphics.FillPath(greenBrush, tmpPath);

            //��������������
            Pen pen = new Pen(Color.Gray);
            graphics.DrawLine(pen, 0, cy, cx * 2, cy);
            graphics.DrawLine(pen, cx, 0, cx, cy * 2);
        }
        //Ӱ�߻�ˢʾ��
        private void Brush_HatchBrush_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //����Ӱ�߻�ˢ��ǰ��ɫ��
            Color black = Color.Black;
            Color white = Color.White;

            //ʹ�õ�һ�ַ���Ӱ�߻�ˢ
            HatchBrush brush = new HatchBrush(HatchStyle.Horizontal, black, white);
            graphics.FillRectangle(brush, 20, 20, 100, 50);

            //ʹ�õڶ��ַ���Ӱ�߻�ˢ
            HatchBrush brush1 = new HatchBrush(HatchStyle.Vertical, black, white);
            graphics.FillRectangle(brush1, 120, 20, 100, 50);

            //ʹ�õ����ַ���Ӱ�߻�ˢ
            HatchBrush brush2 = new HatchBrush(HatchStyle.ForwardDiagonal, black, white);
            graphics.FillRectangle(brush2, 220, 20, 100, 50);

            //ʹ�õ����ַ���Ӱ�߻�ˢ
            HatchBrush brush3 = new HatchBrush(HatchStyle.BackwardDiagonal, black, white);
            graphics.FillRectangle(brush3, 320, 20, 100, 50);

            //ʹ�õ����ַ���Ӱ�߻�ˢ
            HatchBrush brush4 = new HatchBrush(HatchStyle.Cross, black, white);
            graphics.FillRectangle(brush4, 420, 20, 100, 50);

            //ʹ�õ����ַ���Ӱ�߻�ˢ
            HatchBrush brush5 = new HatchBrush(HatchStyle.DiagonalCross, black, white);
            graphics.FillRectangle(brush5, 520, 20, 100, 50);
        }
        //�оٳ����з���Ӱ�߻�ˢ
        private void Brush_EnumAllStyle_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //�趨��ˢ��ǰ��ɫΪ��ɫ������ɫΪ��ɫ
            Color black = Color.Black;
            Color white = Color.White;

            //Ԥ�����������Ŀ�ȼ��߶�
            int WIDTH = 140;
            int HEIGHT = 40;

            //�趨����ı�������Ϣ
            SolidBrush redBrush = new SolidBrush(Color.Red);
            Font myFont = new Font("Arial", 10);

            //column_count������ÿһ���ܹ����ƾ��ε�����
            int column_count = this.Width / WIDTH;
            int rol = 0;
            int column = 0;

            //�ڵ�ǰ����ʹ�����е�Ӱ�߻�ˢ�ַ��������
            Pen pen = new Pen(Color.Blue, 1);
            foreach (HatchStyle style in Enum.GetValues(typeof(HatchStyle)))
            {
                //���һ���Ѿ�������ϣ�����
                if (rol > column_count - 1)
                {
                    column += 2;
                    rol = 0;
                }
                //������ʱ��ˢ
                HatchBrush brush_tmp = new HatchBrush(style, black, white);
                //�����Σ����ÿ��ΪWIDTH-20��Ŀ�����þ���֮���������
                graphics.FillRectangle(brush_tmp, rol * WIDTH, column * HEIGHT, WIDTH - 20, HEIGHT);
                //���ƾ��α߿�
                graphics.DrawRectangle(pen, rol * WIDTH, column * HEIGHT, WIDTH - 20, HEIGHT);

                //��ʾÿ�ֻ�ˢ����ö������
                //�����ı��������
                RectangleF layoutRect = new RectangleF(rol * WIDTH, (column + 1) * HEIGHT, WIDTH, HEIGHT);
                StringFormat format = new StringFormat();
                //�����ı������ʽ��ˮƽ����ֱ����
                format.Alignment = StringAlignment.Near;
                format.LineAlignment = StringAlignment.Center;
                //�ھ��ο��������ö��ֵ
                graphics.DrawString(brush_tmp.HatchStyle.ToString(), myFont, redBrush, layoutRect, format);
                rol += 1;
            }
        }
        //���û���ԭ��
        private void Brush_SetRenderingOrigin_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //�趨��ˢ��ǰ��ɫΪ��ɫ������ɫΪ��ɫ
            Color black = Color.Black;
            Color white = Color.White;
            HatchBrush hatchBrush = new HatchBrush(HatchStyle.DarkDownwardDiagonal, black, white);

            //����ֱ�������8�����Σ�ʹ��Ĭ�ϵĻ�ˢԭ��
            for (int i = 0; i < 8; i++)
            {
                graphics.FillRectangle(hatchBrush, 0, i * 50, 100, 50);
            }

            //ʹ�ò�ͬ�Ļ���ԭ������������
            for (int i = 0; i < 8; i++)
            {
                //���û�ˢԭ��(ˮƽ�������)
                graphics.RenderingOrigin = new Point(i, 0);
                graphics.FillRectangle(hatchBrush, 100, i * 50, 100, 50);
            }
        }
        //����ˢ�Ĳ�ͬ���ط�ʽ
        private void Brush_Texture_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 2);
            SolidBrush brush = new SolidBrush(Color.Black);
            Font myFont = new Font("����", 12);

            //��������ˢ�Ĳ�ͬ�������
            RectangleF rect1 = new RectangleF(10, 10, 200, 200);
            RectangleF rect2 = new RectangleF(210, 10, 200, 200);
            RectangleF rect3 = new RectangleF(410, 10, 200, 200);

            //װ������ͼƬ
            Bitmap image = new Bitmap("nemo.bmp");
            //��������ˢ1��ʹ��Ĭ�ϵķ�ʽ
            TextureBrush tBrush = new TextureBrush(image);
            //ʹ������ˢ���Բ������
            graphics.FillEllipse(tBrush, rect1);
            //����Բ��
            graphics.DrawEllipse(pen, rect1);
            graphics.DrawString("ͼƬԭʼ��С", myFont, brush, new PointF(40, 220));

            //��������ˢ2��ֻʹ�ø���ͼƬ�Ĳ�������
            TextureBrush tBrush2 = new TextureBrush(image, new Rectangle(55, 35, 55, 35));
            graphics.FillEllipse(tBrush2, rect2);
            graphics.DrawEllipse(pen, rect2);
            graphics.DrawString("ʹ�ò��ֽ�ͼ", myFont, brush, new PointF(240, 220));

            //��������ˢ3����ʹ��ͼƬ�Ļ�ˢ��������
            TextureBrush tBrush3 = new TextureBrush(image);
            //�Ի�ˢ����50%������
            Matrix mtr = new Matrix(0.5f, 0.0f, 0.0f, 0.5f, 0.0f, 0.0f);
            tBrush3.Transform = mtr;
            graphics.FillEllipse(tBrush3, rect3);
            graphics.DrawEllipse(pen, rect3);
            graphics.DrawString("������СͼƬ", myFont, brush, new PointF(440, 220));
        }

        //ʹ��ͼƬ���з�ʽ
        private void Brush_Texture_WrapMode_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 2);
            SolidBrush brush = new SolidBrush(Color.Black);
            Font myFont = new Font("Arial", 13);

            //װ������ͼƬ
            Bitmap image = new Bitmap("nemo.bmp");
            //��������ˢ
            TextureBrush tBrush = new TextureBrush(image);
            //����ˢ��������
            Matrix mtr = new Matrix(0.5f, 0.0f, 0.0f, 0.5f, 0.0f, 0.0f);
            tBrush.Transform = mtr;

            int i = 0;
            //��ͼƬ��ʹ�����з�ʽ
            tBrush.WrapMode = WrapMode.Clamp;
            graphics.FillRectangle(tBrush, new Rectangle(i * 150, 0, 150, 150));
            graphics.DrawRectangle(pen, new Rectangle(i * 150, 0, 150, 150));
            graphics.DrawString("Clamp", myFont, brush, new PointF(0, 155));

            i += 1;
            //��ͼƬʹ��ƽ�����з�ʽ	
            tBrush.WrapMode = WrapMode.Tile;
            graphics.FillRectangle(tBrush, new Rectangle(i * 150 + 10, 0, 150, 150));
            graphics.DrawRectangle(pen, new Rectangle(i * 150 + 10, 0, 150, 150));
            graphics.DrawString("Tile", myFont, brush, new PointF(170, 155));

            //��ͼƬʹ��ˮƽ��ת���з�ʽ
            i += 1;
            tBrush.WrapMode = WrapMode.TileFlipX;
            graphics.FillRectangle(tBrush, new Rectangle(i * 150 + 20, 0, 150, 150));
            graphics.DrawRectangle(pen, new Rectangle(i * 150 + 20, 0, 150, 150));

            graphics.DrawString("TileFlipX", myFont, brush, new PointF(320, 155));

            //��ͼƬʹ�ô�ֱ��ת���з�ʽ
            tBrush.WrapMode = WrapMode.TileFlipY;
            graphics.FillRectangle(tBrush, new Rectangle(0, 180, 150, 150));
            graphics.DrawRectangle(pen, new Rectangle(0, 180, 150, 150));
            graphics.DrawString("TileFlipY", myFont, brush, new PointF(0, 335));

            //��ͼƬʹ��ˮƽ����ֱͬʱ��ת���з�ʽ
            tBrush.WrapMode = WrapMode.TileFlipXY;
            graphics.FillRectangle(tBrush, new Rectangle(160, 180, 150, 150));
            graphics.DrawRectangle(pen, new Rectangle(160, 180, 150, 150));
            graphics.DrawString("TileFlipXY", myFont, brush, new PointF(170, 335));
        }
        //����ˢ�ı任
        private void Brush_TextureTransform_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //Ϊ���ֲ�ͬ�ı任��ʽ�Ļ�ˢ�����������
            RectangleF rect1 = new RectangleF(10, 10, 200, 200);
            RectangleF rect2 = new RectangleF(210, 10, 200, 200);
            RectangleF rect3 = new RectangleF(410, 10, 200, 200);

            Pen pen = new Pen(Color.Blue, 2);
            SolidBrush brush = new SolidBrush(Color.Black);
            Font myFont = new Font("����", 12);

            //װ������ͼƬ
            Bitmap image = new Bitmap("nemo.bmp");
            //��������ˢ
            TextureBrush tBrush = new TextureBrush(image);

            //����ˢ��ת30��
            tBrush.RotateTransform(30);
            graphics.FillEllipse(tBrush, rect1);
            graphics.DrawEllipse(pen, rect1);
            graphics.DrawString("��ת30��", myFont, brush, new PointF(40, 220));

            //���ñ任���󣺻ָ����仯ǰ��״̬
            tBrush.ResetTransform();
            //����ˢ��ˮƽ��������������
            tBrush.ScaleTransform(3, 1);
            graphics.FillEllipse(tBrush, rect2);
            graphics.DrawEllipse(pen, rect2);
            graphics.DrawString("������������", myFont, brush, new PointF(240, 220));

            //ƽ�Ʊ任
            tBrush.ResetTransform();
            //����ˢ��ˮƽ������ƽ��30������
            tBrush.TranslateTransform(30, 0, MatrixOrder.Append);
            graphics.FillEllipse(tBrush, rect3);
            graphics.DrawEllipse(pen, rect3);
            graphics.DrawString("����ƽ��30������", myFont, brush, new PointF(440, 220));
        }
        //��ѯ��ˢ�ı任��Ϣ
        private void Brush_GetTextureMatrix_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Matrix matrix = new Matrix();
            float[] elements = new float[6];
            RectangleF rect1 = new RectangleF(10, 10, 200, 200);
            Pen pen = new Pen(Color.Black, 2);
            SolidBrush brush = new SolidBrush(Color.Black);

            Bitmap image = new Bitmap("nemo.bmp");
            TextureBrush tBrush = new TextureBrush(image);
            //������������任
            tBrush.RotateTransform(30);
            tBrush.TranslateTransform(5, 3);
            tBrush.ScaleTransform(0.5f, 2.0f);

            //��ȡĿǰ�Ѿ����еĻ�ˢ�任
            matrix = tBrush.Transform;
            //�Ӿ��ε�����
            elements = matrix.Elements;
            graphics.FillEllipse(tBrush, rect1);
            graphics.DrawEllipse(pen, rect1);

            //��������Ԫ��
            for (int j = 0; j < 6; ++j)
            {
                MessageBox.Show(elements[j].ToString(), "����Ԫ��ֵ");
            }
        }
        //���Խ��仭ˢ����
        private void Brush_LinearGradientBrush_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //����һ���ɺ�ɫ����ɫ����Ļ�ˢ:ˮƽ�任����Ŀ��Ϊ40
            //��ֱ���򲻽���ɫ�ʽ���
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(40, 0),
                Color.Red,  //���ɫ��	
                Color.Blue);  //ֹ��ɫ��

            //����һ��ɫ�ʳʶԽ��߱任�����������СΪ40*40
            LinearGradientBrush linGrBrush2 = new LinearGradientBrush(
                new Point(0, 0),
                new Point(40, 40),
                Color.Red,  //���ɫ��	
                Color.Blue); //ֹ��ɫ��	

            //�ֱ���ʾ��ͬ�����Խ��仭ˢ��Ŀ������Ĳ�ͬ���Ч��
            graphics.FillRectangle(linGrBrush,
                0, 0, 200, 200);
            graphics.FillRectangle(linGrBrush2,
                240, 0, 200, 200);

            Pen pen = new Pen(Color.Gray, 1);
            //�ڶԽ��߷����ϻ��Ƶ�����ˢ���������
            for (int i = 0; i < 5; i++)
            {
                graphics.DrawRectangle(pen,
                    240 + i * 40, i * 40, 40, 40);
            }

        }
        //�������Խ��仭ˢ����䷽ʽ
        private void Brush_LinearArrange_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 2);
            SolidBrush brush = new SolidBrush(Color.Black);
            Font myFont = new Font("Arial", 13);

            //����һ��ɫ�ʳʶԽ��߱任�����������СΪ40*40
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(40, 40),
                Color.Red, //���ɫ��	
                Color.Blue); //ֹ��ɫ��	

            int i = 0;
            //�Խ��仭ˢʹ��ƽ�����з�ʽ(Ĭ�Ϸ�ʽ)
            linGrBrush.WrapMode = WrapMode.Tile;
            //���һ����СΪ160��������
            graphics.FillRectangle(linGrBrush, new Rectangle(i * 160, 0, 160, 160));
            graphics.DrawRectangle(pen, new Rectangle(i * 160, 0, 160, 160));
            graphics.DrawString("Tile", myFont, brush, new Point(20, 165));

            //�Խ��仭ˢʹ��ˮƽ��ת���з�ʽ
            i += 1;
            linGrBrush.WrapMode = WrapMode.TileFlipX;
            //���û�ͼƽ��ԭ��
            graphics.RenderingOrigin = new Point(160, 0);
            graphics.FillRectangle(linGrBrush, new Rectangle(i * 160, 0, 160, 160));
            graphics.DrawRectangle(pen, new Rectangle(i * 160, 160, 0, 160));
            graphics.DrawString("TileFlipX", myFont, brush, new Point(170, 165));

            //�Խ��仭ˢʹ�ô�ֱ��ת���з�ʽ
            linGrBrush.WrapMode = WrapMode.TileFlipY;
            //���û�ͼƽ��ԭ��
            graphics.RenderingOrigin = new Point(0, 200);
            graphics.FillRectangle(linGrBrush, new Rectangle(0, 200, 160, 160));
            graphics.DrawRectangle(pen, new Rectangle(0, 200, 200, 160));
            graphics.DrawString("TileFlipY", myFont, brush, new Point(0, 375));

            //�Խ��仭ˢʹ��ˮƽ����ֱͬʱ��ת���з�ʽ
            linGrBrush.WrapMode = WrapMode.TileFlipXY;
            graphics.RenderingOrigin = new Point(160, 200);
            graphics.FillRectangle(linGrBrush, new Rectangle(160, 200, 160, 160));
            graphics.DrawRectangle(pen, new Rectangle(160, 200, 160, 160));
            graphics.DrawString("TileFlipXY", myFont, brush, new Point(170, 375));

            //��ע���仭ˢ��������Ĵ�С��������
            Pen pen2 = new Pen(Color.Gray, 1);
            for (i = 0; i < 8; i++)
                graphics.DrawLine(pen2, 0, i * 40, 320, i * 40);
            for (i = 0; i < 9; i++)
                graphics.DrawLine(pen2, i * 40, 0, i * 40, 360);
        }
        //�������Խ��仭ˢ�Ľ���ģʽ
        private void Brush_LinearGradientMode_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 2);
            SolidBrush brush = new SolidBrush(Color.Black);
            Font myFont = new Font("Arial", 12);

            //����һ��ˮƽ���仭ˢ����С40*20
            LinearGradientBrush linGrBrush1 = new LinearGradientBrush(
                new Rectangle(0, 0, 40, 20),
                Color.Red,
                Color.Blue, LinearGradientMode.Horizontal);

            //����һ����ֱ���仭ˢ
            LinearGradientBrush linGrBrush2 = new LinearGradientBrush(
                new Rectangle(0, 0, 40, 20),
                Color.Red,
                Color.Blue, LinearGradientMode.Vertical);

            //�����ϵ����µĽ��仭ˢ
            LinearGradientBrush linGrBrush3 = new LinearGradientBrush(
                new Rectangle(0, 0, 40, 20),
                Color.Red,
                Color.Blue, LinearGradientMode.ForwardDiagonal);

            //�����ϵ����µĽ��仭ˢ
            LinearGradientBrush linGrBrush4 = new LinearGradientBrush(
                new Rectangle(0, 0, 40, 20),
                Color.Red,
                Color.Blue, LinearGradientMode.BackwardDiagonal);

            int i = 0;
            //ʹ��ˮƽ����Ļ�ˢ�������
            graphics.FillRectangle(linGrBrush1, new Rectangle(i * 160, 0, 160, 160));
            graphics.DrawRectangle(pen, new Rectangle(i * 160, 0, 160, 160));
            graphics.DrawString("ˮƽ����", myFont, brush, new PointF(20, 165));

            i += 1;
            //���û�ͼƽ��ԭ��
            graphics.RenderingOrigin = new Point(160, 0);
            //ʹ�ô�ֱ����Ļ�ˢ�������
            graphics.FillRectangle(linGrBrush2, new Rectangle(i * 160, 0, 160, 160));
            graphics.DrawRectangle(pen, new Rectangle(i * 160, 160, 0, 160));
            graphics.DrawString("��ֱ����", myFont, brush, new PointF(170, 165));

            //���û�ͼƽ��ԭ��
            graphics.RenderingOrigin = new Point(0, 200);
            //ʹ�ô����ϵ����½���Ļ�ˢ�������
            graphics.FillRectangle(linGrBrush3, new Rectangle(0, 200, 160, 160));
            graphics.DrawRectangle(pen, new Rectangle(0, 200, 200, 160));
            graphics.DrawString("����->����", myFont, brush, new PointF(0, 375));

            graphics.RenderingOrigin = new Point(160, 200);
            graphics.FillRectangle(linGrBrush4, new Rectangle(160, 200, 160, 160));
            //ʹ�ô����ϵ����½���Ļ�ˢ�������
            graphics.DrawRectangle(pen, new Rectangle(160, 200, 160, 160));
            graphics.DrawString("����->����", myFont, brush, new PointF(170, 375));

            //�ڲ�ͬ�������б�ע���彥�䷽��ľ���
            Pen pen2 = new Pen(Color.Gray, 1);
            for (i = 0; i < 18; i++)
                graphics.DrawLine(pen2, 0, i * 20, 320, i * 20);
            for (i = 0; i < 9; i++)
                graphics.DrawLine(pen2, i * 40, 0, i * 40, 360);
        }
        //������ƫת�Ƕ�
        private void Brush_LinearAngle_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 2);
            SolidBrush brush = new SolidBrush(Color.Black);
            Font myFont = new Font("Arial", 12);

            //����һ��������ƫת�Ƕ�Ϊ30�ȵĽ��仭ˢ����С40*20
            LinearGradientBrush linGrBrush1 = new LinearGradientBrush(
                new Rectangle(0, 0, 40, 20),
                Color.Red,
                Color.Blue, 30.0f);
            //����һ��������ƫת�Ƕ�Ϊ45�ȵĽ��仭ˢ
            LinearGradientBrush linGrBrush2 = new LinearGradientBrush(
                new Rectangle(0, 0, 40, 20),
                Color.Red,
                Color.Blue, 45.0f);
            //����һ��������ƫת�Ƕ�Ϊ90�ȵĽ��仭ˢ
            LinearGradientBrush linGrBrush3 = new LinearGradientBrush(
                new Rectangle(0, 0, 40, 20),
                Color.Red,
                Color.Blue, 90.0f);
            //����һ��������ƫת�Ƕ�Ϊ180�ȵĽ��仭ˢ
            LinearGradientBrush linGrBrush4 = new LinearGradientBrush(
                new Rectangle(0, 0, 40, 20),
                Color.Red,
                Color.Blue, 180.0f);

            int i = 0;
            //ʹ��ƫת�Ƕ�Ϊ30�ȵĽ��仭ˢ�������
            graphics.FillRectangle(linGrBrush1, new Rectangle(i * 160, 0, 160, 160));
            graphics.DrawRectangle(pen, new Rectangle(i * 160, 0, 160, 160));
            graphics.DrawString("30��ƫת", myFont, brush, new PointF(20, 165));

            i += 1;
            //���û�ͼƽ��ԭ��
            graphics.RenderingOrigin = new Point(160, 0);
            //ʹ��ƫת�Ƕ�Ϊ45�ȵĽ��仭ˢ�������
            graphics.FillRectangle(linGrBrush2, new Rectangle(i * 160, 0, 160, 160));
            graphics.DrawRectangle(pen, new Rectangle(i * 160, 160, 0, 160));
            graphics.DrawString("45��ƫת", myFont, brush, new PointF(170, 165));

            //���û�ͼƽ��ԭ��
            graphics.RenderingOrigin = new Point(0, 200);
            //ʹ��ƫת�Ƕ�Ϊ90�ȵĽ��仭ˢ�������
            graphics.FillRectangle(linGrBrush3, new Rectangle(0, 200, 160, 160));
            graphics.DrawRectangle(pen, new Rectangle(0, 200, 200, 160));
            graphics.DrawString("90��ƫת", myFont, brush, new PointF(0, 375));

            graphics.RenderingOrigin = new Point(160, 200);
            graphics.FillRectangle(linGrBrush4, new Rectangle(160, 200, 160, 160));
            //ʹ��ƫת�Ƕ�Ϊ180�ȵĽ��仭ˢ�������
            graphics.DrawRectangle(pen, new Rectangle(160, 200, 160, 160));
            graphics.DrawString("180��ƫת", myFont, brush, new PointF(170, 375));

            //�ڲ�ͬ�������б�ע���彥�䷽��ľ���
            Pen pen2 = new Pen(Color.Gray, 1);
            for (i = 0; i < 18; i++)
                graphics.DrawLine(pen2, 0, i * 20, 320, i * 20);
            for (i = 0; i < 9; i++)
                graphics.DrawLine(pen2, i * 40, 0, i * 40, 360);
        }
        //��ɫ���仭ˢ
        private void Brush_LinearInterpolation_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //�������ֲ��뽥���ɫ��
            Color[] colors = 
	{
		Color.Red,   // ��ɫ
		Color.Green,//����ɫΪ��ɫ
		Color.Blue // ��ɫ
	};

            float[] positions = 
	{
		0.0f,   // �ɺ�ɫ��
		0.3f,   // ��ɫʼ�ڻ�ˢ���ȵ�����֮һ
		1.0f   // ����ɫֹ
	};

            //����ColorBlend����
            ColorBlend clrBlend = new ColorBlend(3);
            clrBlend.Colors = colors;
            clrBlend.Positions = positions;

            //����һ���Ӻ�ɫ����ɫ�Ľ��仭ˢ
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(180, 0),
                Color.Black, Color.White);

            //���ý��仭ˢ�Ķ�ɫ������Ϣ
            linGrBrush.InterpolationColors = clrBlend;
            //ʹ�ö�ɫ���仭ˢ���Ŀ������
            graphics.FillRectangle(linGrBrush, 0, 0, 180, 100);

            //ʹ����ͨ�ķ���ʵ�ֶ�ɫ����
            //�ɺ쵽�̣�����60
            LinearGradientBrush linGrBrush1 = new LinearGradientBrush(
                new Point(0, 0),
                new Point(60, 0),
                Color.Red,
                Color.Green);
            //���̵���������120
            LinearGradientBrush linGrBrush2 = new LinearGradientBrush(
                new Point(60, 0),
                new Point(181, 0),
                Color.Green,
                Color.Blue);
            //�ֱ�ʹ��������ˢ����������������γɶ�ɫ����
            graphics.FillRectangle(linGrBrush1, 0, 120, 60, 100);
            graphics.FillRectangle(linGrBrush2, 60, 120, 120, 100);
        }
        //�Զ��彥����̣�������
        private void Brush_LinearCustomize_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush brush = new SolidBrush(Color.Black);
            Font myFont = new Font("����", 12);
            //����һ��˫ɫ���仭ˢ
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(250, 0),
                Color.Red,
                Color.Blue);

            //��������ʹ��Ĭ�Ͻ��䷽ʽ���ľ��Σ��������Ƚ�
            graphics.FillRectangle(linGrBrush, 0, 0, 250, 15);
            graphics.FillRectangle(linGrBrush, 500, 0, 250, 15);

            //���θı�ϳɵ�λ��
            int row = 1;
            for (float i = 0.0f; i < 1.0f; i += 0.1f)
            {
                linGrBrush.SetBlendTriangularShape(i);
                graphics.FillRectangle(linGrBrush, 0, row * 15, 250, 15);
                row++;
            }
            graphics.DrawString("�ı�ϳɵ�λ��",
                myFont, brush, new PointF(40, 200));

            //���θı��ɫ�ϳ�����
            row = 1;
            for (float i = 0.0f; i < 1.0f; i += 0.1f)
            {
                //���ϳɵ����λ�����������������50%��
                linGrBrush.SetBlendTriangularShape(0.5f, i);
                graphics.FillRectangle(linGrBrush, 500, row * 15, 250, 15);
                row++;
            }
            graphics.DrawString("�ı�ɫ�ʺϳ�����",
                myFont, brush, new PointF(540, 200));

        }
        //�����������ߵĽ��仭ˢ		
        private void Brush_LinearGradientBrush_BellShape_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Rectangle myRect = new Rectangle(10, 10, 150, 75);
            //�������Խ��仭ˢ
            LinearGradientBrush myLGBrush = new LinearGradientBrush(
                myRect, Color.Blue, Color.Red, 0.0f, true);

            //ʹ��Ĭ�ϵ����Խ��仭ˢ�����Բ
            graphics.FillEllipse(myLGBrush, myRect);

            //������������óɻ����������ߵĽ���
            myLGBrush.SetSigmaBellShape(.5f, 1.0f);

            //ʹ���Զ��彥����̵Ļ�ˢ�����Բ
            graphics.TranslateTransform(160, 0);
            graphics.FillEllipse(myLGBrush, myRect);
        }

        private void Brush_PathGradientBrush_Star_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Gray, 1);
            SolidBrush pthGrBrush = new SolidBrush(Color.Red);
            SolidBrush blackbrush = new SolidBrush(Color.Blue);
            graphics.TranslateTransform(20, 20);

            //�������ǵ�10���ߵĶ˵�����
            Point[] points = {
								 new Point(75, 0), new Point(100, 50), 
								 new Point(150, 50), new Point(112, 75),
								 new Point(150, 150), new Point(75, 100), 
								 new Point(0, 150), new Point(37, 75), 
								 new Point(0, 50), new Point(50, 50),
								 new Point(75, 0)
							 };

            // ����·��
            GraphicsPath path = new GraphicsPath();
            //��·���м���ֱ��
            path.AddLines(points);
            //���·��
            graphics.FillPath(pthGrBrush, path);
            //���Ʊ߽�
            graphics.DrawLines(pen, points);
            //���ƶ���10���ߵĶ˵�
            for (int i = 0; i < 10; i++)
                //ÿ��Բ���ֱ��Ϊ10
                graphics.FillEllipse(blackbrush, points[i].X - 5, points[i].Y - 5, 10, 10);
        }
        //ʹ��·�����仭ˢ��������
        private void Brush_PathGradientBrush_Star2_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //�������ǵ�10���ߵĶ˵�����
            Point[] points = {
								 new Point(75, 0), new Point(100, 50), 
								 new Point(150, 50), new Point(112, 75),
								 new Point(150, 150), new Point(75, 100), 
								 new Point(0, 150), new Point(37, 75), 
								 new Point(0, 50), new Point(50, 50),
								 new Point(75, 0)
							 };
            // ����·��
            GraphicsPath path = new GraphicsPath();
            //��·�������ֱ��
            path.AddLines(points);
            //����·�����仭ˢ
            PathGradientBrush pthGrBrush = new PathGradientBrush(path);
            //�������ĵ�ɫ��(�յ�ɫ)
            pthGrBrush.CenterColor = Color.Red;

            //����ÿ���˵��ɫ��(�յ�ɫ)
            Color[] colors = new Color[] 
			{
				Color.Black, Color.Green,
				Color.Blue, Color.White, 
				Color.Black, Color.Green, 
				Color.Blue, Color.White,
				Color.Black, Color.Green
			};
            //����·�����仭ˢ�ı�Եɫ
            pthGrBrush.SurroundColors = colors;
            // ���Ŀ��·��
            graphics.FillPath(pthGrBrush, path);

            //������ɫ���߽�ɫ�����ó����ɫ���鿴����Ч��
            Random rand = new Random();
            for (int z = 0; z < 10; z++)
            {
                //��ˮƽ������ƽ�ƻ�ͼƽ��
                graphics.TranslateTransform(200.0f, 0.0f);
                //�������ĵ�ɫ��Ϊ���ɫ
                pthGrBrush.CenterColor =
                    (Color.FromArgb(rand.Next(255) % 155, rand.Next(255) % 255, rand.Next(255) % 255));
                //ʹ��ԭ�еı�Եɫ
                pthGrBrush.SurroundColors = colors;
                graphics.FillPath(pthGrBrush, path);
            }
        }
        //ʹ�ö��·�����仭ˢ
        private void Brush_Using_MorePathGradientBrush_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //����һ�������Σ��߳�Ϊ50	
            float fHalf = 50 * (float)Math.Sin(120.0f / 360.0f * Math.PI);
            PointF[] pts = new PointF[] 
		{
			new PointF( 50, 0),           
			new PointF( 50 * 1.5f,  0),
			new PointF( 50,         0),           
			new PointF( 50 / 2,    -fHalf),
			new PointF(-50 / 2,    -fHalf),
			new PointF(-50,         0),
			new PointF(-50 * 1.5f,  0), 
			new PointF(-50,         0),
			new PointF(-50 / 2,     fHalf),     
			new PointF( 50 / 2,     fHalf)
		};

            //���������ν��仭ˢ
            PathGradientBrush pgbrush1 = new PathGradientBrush(pts);

            //��ˮƽ�ʹ�ֱ������ƽ�������εĶ���
            for (int i = 0; i < 10; i++)
            {
                pts[i].X += 50 * 1.5f;
                pts[i].Y += fHalf;
            }

            //���ݸı������ĵ���������·�����仭ˢ
            PathGradientBrush pgbrush2 = new PathGradientBrush(pts);

            //����·�����仭ˢ�ķ�ת��ʽΪƽ��
            pgbrush1.WrapMode = WrapMode.Tile;
            pgbrush2.WrapMode = WrapMode.Tile;

            //�ֱ�����������ˢ�����ĵ�ɫ��Ϊ�졢��ɫ
            pgbrush1.CenterColor = Color.Red;
            pgbrush2.CenterColor = Color.Green;

            //��䵱ǰ����
            graphics.FillRectangle(pgbrush1, 0, 0, this.Width, this.Height);
            //���ϴ�δ�������������ٴ���䵱ǰ���ڵĿհײ���
            graphics.FillRectangle(pgbrush2, 0, 0, this.Width, this.Height);
        }
        //·�����仭ˢ����䷽ʽ
        private void Brush_PathGradientBrush_WrapMode_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 2);
            SolidBrush brush = new SolidBrush(Color.Black);
            Font myFont = new Font("Arial", 12);

            //�������ǵı������꣬Ϊ��ʾ��תЧ���������ǵ�һ������
            Point[] points = new Point[]
		{
			new Point(75, 0), new Point(100, 50), 
			new Point(150, 50), new Point(112, 75),
			new Point(150, 150), new Point(75, 100), 
			new Point(0, 190), new Point(37, 75), 
			new Point(10, 50), new Point(50, 50)
		};

            GraphicsPath path = new GraphicsPath();
            path.AddLines(points);

            // ����·�����仭ˢ
            PathGradientBrush pthGrBrush = new PathGradientBrush(path);
            //�������ĵ�ɫ��(�յ�ɫ)
            pthGrBrush.CenterColor = Color.Red;

            //����ÿ���˵��ɫ��(�յ�ɫ)
            Color[] colors = new Color[]
		{
			Color.Black,   Color.Green,
			Color.Blue, Color.White, 
			Color.Black,   Color.Green, 
			Color.Blue, Color.White,
			Color.Black,   Color.Green
		};

            pthGrBrush.SurroundColors = colors;
            //��С��ˢ
            pthGrBrush.ScaleTransform(0.2f, 0.2f);
            int i = 0;

            //�Խ��仭ˢʹ��ƽ�����з�ʽ(Ĭ�Ϸ�ʽ)
            pthGrBrush.WrapMode = WrapMode.Tile;
            graphics.FillRectangle(pthGrBrush, new Rectangle(i * 120, 0, 120, 120));
            graphics.DrawRectangle(pen, new Rectangle(i * 120, 0, 120, 120));
            graphics.DrawString("Tile", myFont, brush, new PointF(20, 125));

            i += 1;
            pthGrBrush.WrapMode = WrapMode.TileFlipX;
            graphics.FillRectangle(pthGrBrush, new Rectangle(i * 120, 0, 120, 120));
            graphics.DrawRectangle(pen, new Rectangle(i * 120, 0, 120, 120));
            graphics.DrawString("TileFlipX", myFont, brush, new PointF(170, 125));

            //�Խ��仭ˢʹ�ô�ֱ��ת���з�ʽ
            pthGrBrush.WrapMode = WrapMode.TileFlipY;
            graphics.FillRectangle(pthGrBrush, new Rectangle(0, 200, 120, 120));
            graphics.DrawRectangle(pen, new Rectangle(0, 200, 120, 120));
            graphics.DrawString("TileFlipY", myFont, brush, new PointF(0, 325));

            //�Խ��仭ˢʹ��ˮƽ����ֱͬʱ��ת���з�ʽ
            pthGrBrush.WrapMode = WrapMode.TileFlipXY;
            graphics.FillRectangle(pthGrBrush, new Rectangle(120, 200, 120, 120));
            graphics.DrawRectangle(pen, new Rectangle(120, 200, 120, 120));
            graphics.DrawString("TileFlipXY", myFont, brush, new PointF(170, 325));

            //���·����Լ�����Ρ����ĵ���Ϣ
            RectangleF rect = new RectangleF(); ;
            //��ȡ��ˢ��Լ�����ζ���
            rect = pthGrBrush.Rectangle;
            PointF CenterPoint = new PointF(0, 0);
            //��ȡ��ˢ�����ĵ���Ϣ
            CenterPoint = pthGrBrush.CenterPoint;
            String tmp = new String('S', 256); ;

            //��ʽ���ַ���
            tmp = string.Format("��ǰԼ�����ε���������Ϊ({0},{1}),���={2} �߶�={3}",
                rect.X, rect.Y, rect.Height, rect.Width);
            tmp += "\n" + string.Format("��ǰ����·�������ĵ�����Ϊ({0:F2},{1:F2})",
                CenterPoint.X, CenterPoint.Y);
            //������ĵ㼰Լ�����ζ������Ϣ
            graphics.DrawString(tmp, myFont, brush, new PointF(0, 395));
        }
        //����·�����仭ˢ�����ĵ�
        private void Brush_PathGradientBrush_CenterPoint_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //����һ��Բ������
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, 200, 200);
            SolidBrush brush = new SolidBrush(Color.FromArgb(155, Color.Red));
            //����һ��Բ��·�����仭ˢ
            PathGradientBrush pthGrBrush = new PathGradientBrush(path);

            //�������ĵ�ɫ��
            pthGrBrush.CenterColor = Color.FromArgb(155, Color.White);
            Color[] colors = new Color[] { Color.FromArgb(55, Color.Blue) };
            //���ñ�Եɫ
            pthGrBrush.SurroundColors = colors;
            //�������ʹ�õ�ɫ��ˢ
            graphics.FillEllipse(pthGrBrush, 0, 0, 200, 200);
            //��ȡ���ĵ�ɫ��
            PointF center = new PointF(0, 0);
            center = pthGrBrush.CenterPoint;

            //���Ļ�ˢ�����ĵ���Բ�ܵ��ϰ벿��ƽ��
            for (int i = 0; i < 200; i++)
            {
                center.X = i;
                center.Y = 10;
                pthGrBrush.CenterPoint = center;
                graphics.FillEllipse(pthGrBrush, 0, 0, 200, 200);
                //��ǵ�ǰ���ĵ�
                graphics.FillEllipse(brush, center.X, center.Y, 2, 2);
            }

            //���Ļ�ˢ�����ĵ���Բ�ܵ��°벿��ƽ��
            for (int i = 200; i > 0; i--)
            {
                center.X = i;
                center.Y = 190;
                pthGrBrush.CenterPoint = center;
                graphics.FillEllipse(pthGrBrush, 0, 0, 200, 200);
                //��ǵ�ǰ���ĵ�
                graphics.FillEllipse(brush, center.X, center.Y, 2, 2);
            }

        }
        //��·�����仭ˢʹ�ö�ɫ����
        private void Brush_PathGradientBrush_InterpolationColors_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush brush = new SolidBrush(Color.Red);
            //���������ε�������
            Point[] points = new Point[]
		{
			new Point(100, 0), 
			new Point(200, 200),
			new Point(0, 200)
		};
            //����һ�������ν��仭ˢ
            PathGradientBrush pthGrBrush = new PathGradientBrush(points);
            //-������뽥���ɫ��
            Color[] colors = new Color[] 
		{
			Color.Red,     //��
			Color.Green,     //��
			Color.Blue // ��
		};

            //���úϳɵ��λ��
            float[] pos = new float[] 
		{
			0.0f,    // ��ɫ������߽�Ϊ��ɫ
			0.4f,    //�ھ�������40%��λ�ô�ʹ����ɫ
			1.0f	//���ĵ�ʹ����ɫ
		};

            //���ý���Ĺ���ɫ
            ColorBlend blend = new ColorBlend(3);
            blend.Colors = colors;
            blend.Positions = pos;

            pthGrBrush.InterpolationColors = blend;
            //�������
            graphics.FillRectangle(pthGrBrush, 0, 0, 300, 300);
            //������ĵ�
            PointF centerpoint = new PointF(0, 0); ;
            centerpoint = pthGrBrush.CenterPoint;
            graphics.FillEllipse(brush, centerpoint.X - 5, centerpoint.Y - 5, 10, 10);
        }
        //����·�����仭ˢ�Ľ������ű���
        private void Brsuh_PathGradietBrush_Focus_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Black, 3);
            SolidBrush brush = new SolidBrush(Color.Black);
            Font myFont = new Font("Arial", 12);

            //ָ����������������,���������ν��仭
            Point[] points = new Point[]
	{
		new Point(100, 0),
		new Point(200, 200), 
		new Point(0, 200)
	};

            PathGradientBrush pthGrBrush = new PathGradientBrush(points);
            //ָ������ɫ
            Color[] colors = new Color[] { Color.Red, Color.Blue };
            //ָ��ɫ�ʺϳ�λ��
            float[] relativePositions = new float[]
		{
			0.0f,    // ��ɫ���߽�
			1.0f // ��ɫΪ����
		};

            //����ColorBlend����
            ColorBlend clrBlend = new ColorBlend();
            clrBlend.Colors = colors;
            clrBlend.Positions = relativePositions;
            //���ý���ɫ
            pthGrBrush.InterpolationColors = clrBlend;

            //ʹ��Ĭ���������ӽ������
            graphics.FillRectangle(pthGrBrush, 0, 0, 200, 200);

            //��ȡĬ���������� 
            PointF FocusScales = new PointF(0, 0);
            FocusScales = pthGrBrush.FocusScales;
            //���������Ϣ
            String tmp = new String('D', 256);
            tmp = String.Format("ˮƽ:x={0:F2}\n��ֱ:y={1:F2}", FocusScales.X, FocusScales.Y);
            graphics.DrawString(tmp, myFont, brush, new PointF(0, 210));

            //ƽ�ƻ�ͼƽ��
            graphics.TranslateTransform(200, 0);
            //������������
            FocusScales.X = 0.6f;
            FocusScales.Y = 0.6f;
            pthGrBrush.FocusScales = FocusScales;

            graphics.FillRectangle(pthGrBrush, 0, 0, 200, 200);
            graphics.DrawString("ˮƽ:x=0.6\n��ֱ:y=0.6",
                myFont, brush, new PointF(0, 210));

            //ˮƽ���Ų����ڴ�ֱ����ʱ����
            graphics.TranslateTransform(200, 0);
            //������������
            FocusScales.X = 0.1f;
            FocusScales.Y = 0.8f;
            pthGrBrush.FocusScales = FocusScales;

            graphics.FillRectangle(pthGrBrush, 0, 0, 200, 200);
            graphics.DrawString("ˮƽ:x=0.1\n��ֱ:y=0.8",
                myFont, brush, new PointF(0, 210));

            //ˮƽ����=��ֱ����=1.0
            graphics.TranslateTransform(200, 0);
            FocusScales.X = 1.0f;
            FocusScales.Y = 1.0f;
            pthGrBrush.FocusScales = FocusScales;

            graphics.FillRectangle(pthGrBrush, 0, 0, 200, 200);
            graphics.DrawString("ˮƽ:x=1.0\n��ֱ:y=1.0",
                myFont, brush, new PointF(0, 210));

            //ˮƽ���Ų����ڴ�ֱ����ʱ�������Ŵ�ԭ������
            graphics.TranslateTransform(200, 0);
            FocusScales.X = 2.0f;
            FocusScales.Y = 1.5f;
            pthGrBrush.FocusScales = FocusScales;

            graphics.FillRectangle(pthGrBrush, 0, 0, 200, 200);
            graphics.DrawString("ˮƽ:x=2.0\n��ֱ:y=1.5",
                myFont, brush, new PointF(0, 210));

        }
        //·�����仭ˢ�ı任
        private void Brush_PathGradientBrush_Transform_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            // ����һ��������·�����仭ˢ
            Point[] pts = new Point[] { new Point(50, 0), new Point(100, 100), new Point(0, 100) };
            PathGradientBrush pthGrBrush = new PathGradientBrush(pts);

            //�Ի�ˢʹ�ô�ֱ��ת��ʽ
            pthGrBrush.WrapMode = WrapMode.TileFlipY;
            //��С��ˢ	
            pthGrBrush.ScaleTransform(0.5f, 0.5f);
            //��䵱ǰ����
            graphics.FillRectangle(pthGrBrush, 0, 0, this.Width, this.Height);

            //����ˢ��ת90��
            pthGrBrush.RotateTransform(90.0f, MatrixOrder.Append);
            //�ٴ���䵱ǰ����
            graphics.FillRectangle(pthGrBrush, 0, 0, this.Width, this.Height);
        }

        private void Brsuh_LinearGradientBrush_UsingGamma_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            LinearGradientBrush linGrBrush = new LinearGradientBrush(
                new Point(0, 10),
                new Point(200, 10),
                Color.Red,
                Color.Blue);

            graphics.FillRectangle(linGrBrush, 0, 0, 200, 50);
            linGrBrush.GammaCorrection = true;
            graphics.FillRectangle(linGrBrush, 0, 60, 200, 50);

        }
        //�򵥵�ʹ������ʾ��
        private void Font_UsingFontInGDIPlus_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White); ;
            //�½�һ������Ի���
            FontDialog dlg = new FontDialog();
            //������������ɫ������
            dlg.ShowColor = true;
            //��������ѡ��Ի���
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            //��ȡ������Ի����е�������Ϣ
            Font myFont = dlg.Font;
            //��������ɫ�ʴ�����ˢ
            SolidBrush brush = new SolidBrush(dlg.Color);
            //�����ı������ʽ���ڵ�ǰ�����о�����ʾ
            StringFormat fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Center;
            fmt.LineAlignment = StringAlignment.Center;
            //����ı�
            graphics.DrawString("����ı�", myFont, brush, new Rectangle(0, 0, this.Width, this.Height), fmt);

        }
        //ö�����е�����ϵ��
        private void Font_EnumAllFonts_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush solidBrush = new SolidBrush(Color.Black);
            FontFamily fontFamily = new FontFamily("Arial");
            Font font = new Font(fontFamily, 8, FontStyle.Regular, GraphicsUnit.Point);
            //�����ı������ʽ
            StringFormat fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Near;
            fmt.LineAlignment = StringAlignment.Near;

            string tmp = "";
            //��ȡ�����Ѿ���װ������ϵ��
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            FontFamily[] fontfamily = installedFontCollection.Families;
            int index = 0;
            //����fontfamily�����ÿһ����Ա
            foreach (FontFamily i in fontfamily)
            {
                //��ȡ��ǰ����ϵ������
                tmp += i.Name + ", ";
                index++;
            }

            //�ڴ�����������е�����ϵ����
            Rectangle r = new Rectangle(0, 10, this.Width, this.Height);
            graphics.DrawString(tmp, font, solidBrush, r, fmt);
            //�������ϵ����Ϣ
            tmp = String.Format("�����ϵͳ���Ѿ���װ��������{0}�֣������Ʒֱ�Ϊ:\n", index + 1);
            graphics.DrawString(tmp, font, solidBrush, new Point(0, 0));
        }

        //������ǿ��ѡ��Ի����
        private void Font_EnhanceFontDialog_Click(object sender, System.EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }
        //ʹ�ò�ͬ�������Ե����ʽ
        private void Font_UsingTextRenderHint_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush brs = new SolidBrush(Color.Black);
            FontFamily fontFamily = new FontFamily("Arial");
            Font font = new Font(fontFamily, 60, FontStyle.Regular, GraphicsUnit.Pixel);

            //ʹ�ò�ͬ�ı�Ե����ʽ��������ı�
            foreach (TextRenderingHint Render in Enum.GetValues(typeof(TextRenderingHint)))
            {
                //���ñ�Ե����ʽ
                graphics.TextRenderingHint = Render;
                //����ı�
                graphics.DrawString("Render", font, brs, new PointF(0, 0));
                //��ͼƽ�����Ƶ���
                graphics.TranslateTransform(0, font.Height);
            }
        }
        //ʹ��˽�����弯��
        private void Font_Privatefontcollection_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            PointF pointF = new PointF(0.0f, 10.0f);
            SolidBrush solidBrush = new SolidBrush(Color.Red);
            //����˽�����弯
            PrivateFontCollection privateFontCollection = new PrivateFontCollection();

            //��˽�����弯��׷���㷱�����ֿ��ļ�"������.TTF"
            string fontfile = "c:\\������.TTF";
            try
            {
                privateFontCollection.AddFontFile(fontfile);
            }
            catch
            {
                MessageBox.Show("�����ļ�����ʧ��", "��������");
                return;
            }

            //��˽�����弯���й��췱���壬��СΪ35����
            FontFamily pFontFamily = new FontFamily("���㷱����", privateFontCollection);
            Font tmpFont = new Font(pFontFamily, 35);
            //�������������
            graphics.DrawString("���۲���ǧ����", tmpFont, solidBrush, pointF);
            //��ֱ����һ��һ�У��и�Ϊ  ����ĸ߶�
            pointF.Y += tmpFont.Height;
            graphics.DrawString("����ǰͷ��ľ��", tmpFont, solidBrush, pointF);
        }

        private void menuItem9_Click(object sender, System.EventArgs e)
        {

        }
        //��˽�����弯����ʹ�ö�������
        private void Font_Privatefontcollection2_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            PointF pointF = new PointF(0.0f, 10.0f);
            SolidBrush solidBrush = new SolidBrush(Color.Red);
            //����˽�����弯
            PrivateFontCollection privateFontCollection = new PrivateFontCollection();
            //��˽�����弯��׷��������ͬ�������ļ�
            privateFontCollection.AddFontFile("C:\\WINDOWS\\Fonts\\STCAIYUN.TTF");
            privateFontCollection.AddFontFile("C:\\WINDOWS\\Fonts\\SIMLI.TTF");
            privateFontCollection.AddFontFile("C:\\WINDOWS\\Fonts\\Arial.ttf");

            //����˽�����弯���е���������ϵ��
            foreach (FontFamily i in privateFontCollection.Families)
            {
                Font tmpFont = new Font(i, 35);
                //�������������
                graphics.DrawString("������:  " + i.Name, tmpFont, solidBrush, pointF);
                graphics.TranslateTransform(0, tmpFont.Height);
            }

            //ͨ������PrivateFontCollection���Families�����Ա������
            for (int index = 0; index < privateFontCollection.Families.Length; index++)
            {
                Font tmpFont = new Font(privateFontCollection.Families[index].Name, 35);
                //�������������
                graphics.DrawString("������:  " + privateFontCollection.Families[index].Name,
                    tmpFont, solidBrush, pointF);
                graphics.TranslateTransform(0, tmpFont.Height);
            }
        }
        //����������Ƿ����
        private void Font_IsStyleAvailable_Click(object sender, System.EventArgs e)
        {

            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Gray);
            PointF pointF = new PointF(10.0f, 0.0f);
            SolidBrush solidBrush = new SolidBrush(Color.Black);
            //��Ϣ�����ʹ�õ�����
            Font msgfont = new Font("Arial", 12);

            //����˽�����弯
            PrivateFontCollection privateFontCollection = new PrivateFontCollection();
            //��˽�����弯��׷�����������ļ�
            //����
            privateFontCollection.AddFontFile("C:\\windows\\Fonts\\simhei.ttf");
            //Courier New����
            privateFontCollection.AddFontFile("C:\\windows\\Fonts\\CourBI.ttf");
            //���Ŀ���_GB2312
            privateFontCollection.AddFontFile("C:\\windows\\Fonts\\STLITI.ttf");

            string familyName = string.Empty;
            string tmpmsg = string.Empty;

            //��ѯ˽�����弯������ϵ������
            int count = privateFontCollection.Families.Length;
            //��ȡ����ϵ������
            FontFamily[] pFontFamily = new FontFamily[count];
            //������ϵ���е��������м���pFontFamily��
            pFontFamily = privateFontCollection.Families;

            /*��˽�����弯��ÿһ������ϵ�н�������������
            �Ĳ�ѯ�������������ã�ʹ�ø÷������ı�����
            */
            for (int j = 0; j < count; ++j)
            {
                //������ϵ���л�ȡ������
                familyName = pFontFamily[j].Name;
                // �������Ƿ����
                if (pFontFamily[j].IsStyleAvailable(FontStyle.Regular))
                {
                    tmpmsg = "  ����ĳ��������";
                    //��������
                    FontFamily fm = new FontFamily(familyName, privateFontCollection);
                    Font tmpFont = new Font(fm,
                        12, FontStyle.Regular, GraphicsUnit.Pixel);
                    //���ʹ�ó����������
                    graphics.DrawString(familyName + tmpmsg, tmpFont, solidBrush, pointF);
                    //��ֱ����һ��һ�У��и�Ϊ  ����ĸ߶�
                    pointF.Y += tmpFont.Height;
                }
                else
                {
                    graphics.DrawString(familyName + tmpmsg +
                        "  ����ĳ����񲻿���", msgfont, solidBrush, pointF);
                    pointF.Y += msgfont.Height;
                }
                tmpmsg = string.Empty;

                // �������Ƿ����
                if (pFontFamily[j].IsStyleAvailable(FontStyle.Bold))
                {
                    tmpmsg = "  ����Ĵ��������";
                    //��������
                    FontFamily fm = new FontFamily(familyName, privateFontCollection);
                    Font tmpFont = new Font(fm,
                        12, FontStyle.Bold, GraphicsUnit.Pixel);
                    //���ʹ�ó����������
                    graphics.DrawString(familyName + tmpmsg, tmpFont, solidBrush, pointF);
                    //��ֱ����һ��һ�У��и�Ϊ  ����ĸ߶�
                    pointF.Y += tmpFont.Height;
                }
                else
                {
                    graphics.DrawString(familyName + tmpmsg +
                        "  ����Ĵ����񲻿���", msgfont, solidBrush, pointF);
                    pointF.Y += msgfont.Height;
                }
                tmpmsg = string.Empty;

                // б�����Ƿ����
                if (pFontFamily[j].IsStyleAvailable(FontStyle.Italic))
                {
                    tmpmsg = "  �����б�������";
                    //��������
                    FontFamily fm = new FontFamily(familyName, privateFontCollection);
                    Font tmpFont = new Font(fm,
                        12, FontStyle.Italic, GraphicsUnit.Pixel);
                    //���ʹ�ó����������
                    graphics.DrawString(familyName + tmpmsg, tmpFont, solidBrush, pointF);
                    //��ֱ����һ��һ�У��и�Ϊ  ����ĸ߶�
                    pointF.Y += tmpFont.Height;
                }
                else
                {
                    graphics.DrawString(familyName + tmpmsg +
                        "  �����б���񲻿���", msgfont, solidBrush, pointF);
                    pointF.Y += msgfont.Height;
                }
                tmpmsg = string.Empty;

                // ��ѯ�»��߷���Ƿ����
                if (pFontFamily[j].IsStyleAvailable(FontStyle.Underline))
                {
                    tmpmsg = "  ������»��߷�����";
                    //��������
                    FontFamily fm = new FontFamily(familyName, privateFontCollection);
                    Font tmpFont = new Font(fm,
                        12, FontStyle.Underline, GraphicsUnit.Pixel);
                    //���ʹ�ó����������
                    graphics.DrawString(familyName + tmpmsg, tmpFont, solidBrush, pointF);
                    //��ֱ����һ��һ�У��и�Ϊ  ����ĸ߶�
                    pointF.Y += tmpFont.Height;
                }
                else
                {
                    graphics.DrawString(familyName + tmpmsg +
                        "  ������»��߷�񲻿���", msgfont, solidBrush, pointF);
                    pointF.Y += msgfont.Height;
                }
                tmpmsg = string.Empty;

                // ��ѯǿ���߷���Ƿ����
                if (pFontFamily[j].IsStyleAvailable(FontStyle.Strikeout))
                {
                    tmpmsg = "  �����ǿ���߷�����";
                    //��������
                    FontFamily fm = new FontFamily(familyName, privateFontCollection);
                    Font tmpFont = new Font(fm,
                        12, FontStyle.Strikeout, GraphicsUnit.Pixel);
                    //���ʹ�ó����������
                    graphics.DrawString(familyName + tmpmsg, tmpFont, solidBrush, pointF);
                    //��ֱ����һ��һ�У��и�Ϊ  ����ĸ߶�
                    pointF.Y += tmpFont.Height;
                }
                else
                {
                    graphics.DrawString(familyName + tmpmsg +
                        "  �����ǿ���߷�񲻿���", msgfont, solidBrush, pointF);
                    pointF.Y += msgfont.Height;
                }
                tmpmsg = string.Empty;

                // �ڲ�ͬ������ϵ��֮����ϼ����
                graphics.DrawLine(pen, 0, (int)pointF.Y, 400, (int)pointF.Y);
                pointF.Y += 10.0f;
            }
        }
        //��ȡ����Ĵ�С
        private void Font_Size_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            PointF pointF = new PointF(0.0f, 0.0f);
            SolidBrush solidBrush = new SolidBrush(Color.Black);

            string infoString = string.Empty;
            int ascent;
            float ascentPixel;
            int descent;
            float descentPixel;
            int lineSpacing;
            float lineSpacingPixel;

            FontFamily fontFamily = new FontFamily("Arial");
            //����һ����СΪ16���ص�Aria����
            Font font = new Font(fontFamily, 16, FontStyle.Regular, GraphicsUnit.Pixel);
            Font font2 = new Font(fontFamily, 14, FontStyle.Regular, GraphicsUnit.Pixel);

            // ��ʾ�����С
            infoString = string.Format("font��Size����ֵΪ{0:F2}", font.Size);
            graphics.DrawString(infoString, font2, solidBrush, pointF);
            // ����һ��
            pointF.Y += font2.Height;
            //��ʾ����߶ȣ�����
            infoString = string.Format("font��Height����ֵΪ{0:F2}", font.Height);
            graphics.DrawString(infoString, font2, solidBrush, pointF);
            // ����һ��
            pointF.Y += font2.Height;

            // ��ʾ����ϵ�еĸ߶�(��Ƶ�λ)
            infoString = string.Format("ʹ��fontFamily.GetEmHeight�������ص�����߶�Ϊ{0}����Ƶ�λ��"
                , fontFamily.GetEmHeight(FontStyle.Regular));
            graphics.DrawString(infoString, font2, solidBrush, pointF);

            // ��������(Height���Ե�ֵ������ĸ߶ȣ���λΪ����)
            pointF.Y += 2.0f * font2.Height;

            // ��ȡ�����Ascent(�ϲ�����)
            ascent = fontFamily.GetCellAscent(FontStyle.Regular);

            //���ϲ��������Ƶ�λת�������ص�λ
            ascentPixel =
                font.Size * ascent / fontFamily.GetEmHeight(FontStyle.Regular);
            infoString = string.Format("�ϲ�����Ϊ{0}����Ƶ�λ, {1:F2}�����ء�",
                ascent, ascentPixel);
            graphics.DrawString(infoString, font2, solidBrush, pointF);

            // ����һ��
            pointF.Y += font2.Height;
            // ��ȡ�����Descent(�²�����),��Ƶ�λ
            descent = fontFamily.GetCellDescent(FontStyle.Regular);

            //���²��������Ƶ�λת�������ص�λ
            descentPixel =
                font.Size * descent / fontFamily.GetEmHeight(FontStyle.Regular);
            infoString = string.Format("�²�����Ϊ{0} ����Ƶ�λ,{1:F2}�����ء�",
                descent, descentPixel);
            graphics.DrawString(infoString, font2, solidBrush, pointF);

            // ����һ��
            pointF.Y += font2.Height;
            //��ȡ�о�(��Ƶ�λ)
            lineSpacing = fontFamily.GetLineSpacing(FontStyle.Regular);
            //���о����Ƶ�λת�������ص�λ
            lineSpacingPixel =
                font.Size * lineSpacing / fontFamily.GetEmHeight(FontStyle.Regular);
            infoString = string.Format("�о�Ϊ{0} ����Ƶ�λ,{1:F2} ���ء�",
                lineSpacing, lineSpacingPixel);
            graphics.DrawString(infoString, font2, solidBrush, pointF);
        }
        //�����ı��������
        private void Font_BaseLine_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            FontFamily fontFamily = new FontFamily("Arial");
            //����һ����СΪ60���ص�Aria����
            Font font = new Font(fontFamily, 60, FontStyle.Regular, GraphicsUnit.Pixel);
            //��ȡ��ǰ���ڵľ��ο���
            int cy = this.Height;
            int cx = this.Width;

            Pen pen = new Pen(Color.Blue, 1);
            SolidBrush brush = new SolidBrush(Color.Blue);

            //�����ڴ�ֱ�����1/2������Ϊ����
            float yBaseline = cy / 2;
            //���ƻ���
            graphics.DrawLine(pen, new PointF(0, yBaseline), new PointF(cx, yBaseline));
            //�õ�����߶�
            float cyLineSpace = font.Height;
            //��ȡ�о�
            int iCellSpace = fontFamily.GetLineSpacing(FontStyle.Regular);
            //�õ��ϰ벿�־���
            int iCellAscent = fontFamily.GetCellAscent(FontStyle.Regular);
            //�����ı��������ʼλ������ڻ��ߵ�ƫ��
            float cyAscent = cyLineSpace * iCellAscent / iCellSpace;

            //���������ϻ�������ֱ�ߣ����ΪcyAscent
            graphics.DrawLine(pen,
                new PointF(0, yBaseline - cyAscent), new PointF(cx, yBaseline - cyAscent));
            graphics.DrawLine(pen,
                new PointF(0, yBaseline - 2.0f * cyAscent), new PointF(cx, yBaseline - 2.0f * cyAscent));

            //�ֱ�����������������ı�
            graphics.DrawString("AaFfgSs}", font, brush, new PointF(0, yBaseline - cyAscent));
            graphics.DrawString("AaFfgSs}", font, brush, new PointF(0, yBaseline - 2.0f * cyAscent));

        }

        private void Font_DrawString_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //����ı�
            string msg = "ʾ���ı�";

            Font myFont = new Font("����", 16);
            Rectangle layoutRect = new Rectangle(50, 50, 200, 50);
            //���ö��뷽ʽ
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            SolidBrush blackBrush = new SolidBrush(Color.Black);

            // �����ı�
            graphics.DrawString(msg, myFont, blackBrush, layoutRect, format);
            // �����ı�����ľ�������
            graphics.DrawRectangle(new Pen(Color.Black, 3), layoutRect);

        }

        private void Font_MeasureString_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //����һ�����������ı����ַ���
            string txtOut = "123456789\n";
            txtOut += "ABCDEFGHIJKLM\n";
            txtOut += "һ�����������߰˾�";

            FontFamily fontFamily = new FontFamily("Arial");
            //������������С��ͬ��Aria����
            Font font = new Font(fontFamily, 30, FontStyle.Regular, GraphicsUnit.Pixel);
            Font font2 = new Font(fontFamily, 14, FontStyle.Regular, GraphicsUnit.Pixel);
            SolidBrush brush = new SolidBrush(Color.Black);

            StringFormat fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Center;
            fmt.LineAlignment = StringAlignment.Center;

            SizeF stringSize = new SizeF();
            //��������ַ�������Ҫ�ľ��οռ�
            stringSize = graphics.MeasureString(txtOut, font);

            string tmp = string.Empty;
            tmp = string.Format("����ַ�������Ҫ�Ŀ��Ϊ:{0:F2}  �߶�Ϊ{1:F2}",
                stringSize.Width, stringSize.Height, font.Height);

            // ��������ı������ƾ���
            graphics.DrawRectangle(new Pen(Color.Red),
                10.0f, 10.0f, stringSize.Width, stringSize.Height);
            //����ַ����Ĳ�����Ϣ
            graphics.DrawString(txtOut, font, brush,
                new RectangleF(10.0f, 10.0f, stringSize.Width, stringSize.Height), fmt);
            graphics.TranslateTransform(0, 10 + stringSize.Height);
            graphics.DrawString(tmp, font2, brush, new PointF(0, 0));
        }
        //������ָ������������ʾ���ַ�����������
        private void Font_MeasureString2_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            string txtOut = "123456789";
            txtOut += "ABCDEFGHIJKLM";
            txtOut += "һ�����������߰˾�";

            FontFamily fontFamily = new FontFamily("Arial");
            //������������С��ͬ��Aria����
            Font font = new Font(fontFamily, 30, FontStyle.Regular, GraphicsUnit.Pixel);
            Font font2 = new Font(fontFamily, 14, FontStyle.Regular, GraphicsUnit.Pixel);
            //�����ı��������
            Rectangle layoutRect = new Rectangle(10, 10, 100, 100);
            SolidBrush brush = new SolidBrush(Color.Black);

            //�����ı���ʾ��ʽ
            StringFormat fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Center;
            fmt.LineAlignment = StringAlignment.Center;

            int codepointsFitted = 0;
            int linesFilled = 0;

            SizeF stringSize = new SizeF();
            //����ָ���������ܹ���ʾ���ַ�����������
            stringSize = graphics.MeasureString(txtOut,
                font, new SizeF(layoutRect.Width, layoutRect.Height),
                fmt, out codepointsFitted, out linesFilled);

            string tmp = string.Empty;
            tmp = string.Format("��������ִ���{0}���ַ�\n����,��ָ�������������\nֻ�����{1}�й�{2}���ַ�", txtOut.Length, linesFilled, codepointsFitted);

            // ����ָ�����ı��������
            graphics.DrawRectangle(new Pen(Color.Blue, 2), layoutRect);
            //��ָ���������������ʾ�ı�
            graphics.DrawString(txtOut, font, brush, layoutRect, fmt);

            //����ַ����Ĳ�����Ϣ
            graphics.TranslateTransform(0, 10 + stringSize.Height);
            graphics.DrawString(tmp, font2, brush, new PointF(0, 0));
        }
        //�ı��ķ������
        private void Font_ColumnTextOut_Click(object sender, System.EventArgs e)
        {
            //ѡ����������ʾ���ļ�
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowReadOnly = true;
            //�ļ��Ի������
            dlg.Title = "ѡ����������ʾ���ı��ļ�";
            dlg.Filter = "�ı��ļ� (*.txt)|*.txt|�����ļ� (*.*)|*.*";
            //ѡ����ȡ��
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            StreamReader stream = new StreamReader(dlg.FileName,
                System.Text.Encoding.Unicode);
            string buffer = string.Empty;
            //��ȡ���е��ļ�����	
            buffer = stream.ReadToEnd();
            //�ر��ļ�
            stream.Close();
            String str = buffer;

            //��������������֮��ļ��
            int COLUMWIDTH = 100;
            int SPACE = 10;

            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush brush = new SolidBrush(Color.Black);
            Font myFont = new Font("����", 10);
            int codepointsFitted = 0;
            int linesFilled = 0;

            //���������ʽ
            StringFormat format = new StringFormat();
            //�����Զ�����
            format.FormatFlags = StringFormatFlags.NoClip;
            //����ı��Ե��ʽ���
            format.Trimming = StringTrimming.Word;

            //�������Ұ���(��)����ı�
            for (int x = 0; str.Length > 0 && x < this.Width; x += (COLUMWIDTH + SPACE))
            {
                //�����ı���Ӧ�ľ�������(һ��)
                RectangleF layoutRect = new RectangleF(x, 0,
                    COLUMWIDTH, this.Height - myFont.Height);
                SizeF stringSize = new SizeF();
                //����ָ���������ܹ���ʾ���ַ�����������
                stringSize = graphics.MeasureString(str,
                    myFont, new SizeF(layoutRect.Width, layoutRect.Height),
                    format, out codepointsFitted, out linesFilled);

                //��ʾһ���ı�
                graphics.DrawString(str, myFont, brush, layoutRect, format);
                //ȥ���Ѿ�������ַ����Ա���һ���ܹ�������ʾ			  
                str = str.Substring(codepointsFitted);
            }
        }
        //�����ı���ȥβ��ʽ
        private void Font_StirngTrimming_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush solidBrush = new SolidBrush(Color.Black);
            FontFamily fontFamily = new FontFamily("Times New Roman");
            //�����ı����������
            Font font = new Font(fontFamily, 25, FontStyle.Regular, GraphicsUnit.Pixel);

            Pen pen = new Pen(Color.Red);
            StringFormat stringFormat = new StringFormat();
            //������ʾ��Ϣ�����弰��ʽ
            Font font2 = new Font(fontFamily, 14, FontStyle.Regular, GraphicsUnit.Pixel);
            //�����ı�����ĸ�ʽ
            StringFormat msgFormat = new StringFormat();
            msgFormat.Alignment = StringAlignment.Center;
            msgFormat.LineAlignment = StringAlignment.Center;

            //��ʾ��Ϣ�������
            RectangleF outrect = new RectangleF(30, 100, 160, font2.Height * 2);

            //ȥβ��ʽ��Character
            stringFormat.Trimming = StringTrimming.Character;
            //����ı�
            string text = "One two three four five seven eight nine ten";
            graphics.DrawString(text, font, solidBrush,
                new Rectangle(30, 30, 160, 60),
                stringFormat);

            //�����ı��������
            graphics.DrawRectangle(pen, 30, 30, 160, 60);
            //�����ʾ��Ϣ
            graphics.DrawString("Character", font2, solidBrush, outrect,
                msgFormat);

            //��ͼƽ����ˮƽ����ƽ��160������
            graphics.TranslateTransform(160, 0);

            //����ȥβ��ʽ��Word
            stringFormat.Trimming = StringTrimming.Word;
            graphics.DrawString(text, font, solidBrush,
                new Rectangle(30, 30, 160, 60),
                stringFormat);
            graphics.DrawRectangle(pen, 30, 30, 160, 60);
            graphics.DrawString("Word", font2, solidBrush, outrect,
                msgFormat);


            //����ȥβ��ʽ��EllipsisCharacter
            graphics.TranslateTransform(160, 0);
            stringFormat.Trimming = StringTrimming.EllipsisCharacter;
            graphics.DrawString(text, font, solidBrush,
                new Rectangle(30, 30, 160, 60),
                stringFormat);
            graphics.DrawRectangle(pen, 30, 30, 160, 60);
            graphics.DrawString("EllipsisCharacter", font2, solidBrush, outrect,
                msgFormat);


            //����ȥβ��ʽ��EllipsisWord
            graphics.TranslateTransform(160, 0);
            stringFormat.Trimming = StringTrimming.EllipsisWord;
            graphics.DrawString(text, font, solidBrush,
                new Rectangle(30, 30, 160, 60),
                stringFormat);
            graphics.DrawRectangle(pen, 30, 30, 160, 60);
            graphics.DrawString("EllipsisWord", font2, solidBrush, outrect,
                msgFormat);

            //����ȥβ��ʽ��EllipsisPath
            graphics.TranslateTransform(160, 0);
            stringFormat.Trimming = StringTrimming.EllipsisPath;
            graphics.DrawString(text, font, solidBrush,
                new Rectangle(30, 30, 160, 60),
                stringFormat);
            graphics.DrawRectangle(pen, 30, 30, 160, 60);
            graphics.DrawString("EllipsisPath", font2, solidBrush, outrect,
                msgFormat);

        }
        //�ı�����ļ��ô���
        private void Font_TextOutClip_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush solidBrush = new SolidBrush(Color.Black);
            FontFamily fontFamily = new FontFamily("����");
            Font font = new Font(fontFamily, 25,
                FontStyle.Regular, GraphicsUnit.Pixel);

            Pen pen = new Pen(Color.Red);
            StringFormat stringFormat = new StringFormat();
            RectangleF outtext = new RectangleF(10, 10, 120, 45);
            //ʹ��Ĭ��ֵ����ı�
            string text = "�ı��ļ���ʾ��";
            graphics.DrawString(text, font, solidBrush, outtext,
                stringFormat);
            //�����ı��������
            graphics.DrawRectangle(pen, outtext.X,
                outtext.Y, outtext.Width, outtext.Height);

            //��ˮƽ����ƽ��170�����ظ�
            graphics.TranslateTransform(120, 0);
            RectangleF out2 = outtext;
            //���������ĸ߶ȵ���Ϊ����߶ȵ�������
            out2.Height = font.Height * 2;
            graphics.DrawString(text, font, solidBrush, out2,
                stringFormat);
            //�����ı��������
            graphics.DrawRectangle(pen, out2.X,
                out2.Y, out2.Width, out2.Height);

            graphics.TranslateTransform(120, 0);
            //������ı�ʱ��ʹ�ü���
            stringFormat.FormatFlags = StringFormatFlags.NoClip;
            graphics.DrawString(text, font, solidBrush, outtext,
                stringFormat);

            //�����ı��������
            graphics.DrawRectangle(pen, outtext.X, outtext.Y,
                outtext.Width, outtext.Height);
        }
        //�����ı��ֲ��������
        private void Font_MeasureCharacterRanges_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            // ���û����ı����������Ļ�ˢ
            SolidBrush TextBrush = new SolidBrush(Color.Red);
            SolidBrush RegionBrush = new SolidBrush(Color.FromArgb(100, Color.Black));
            Pen blackPen = new Pen(Color.Black);

            // ʹ��������Ȳ�ͬ�ľ�����������ı���ʾ�ⲻͬ�ֲ�����������
            RectangleF layoutRect_A = new RectangleF(20.0f, 20.0f, 120.0f, 180.0f);
            RectangleF layoutRect_B = new RectangleF(140.0f, 20.0f, 140.0f, 180.0f);
            RectangleF layoutRect_C = new RectangleF(280.0f, 20.0f, 180.0f, 180.0f);

            //�����Ҫ������ִ�
            string ts = "��ʱ���º�ʱ�أ�";
            ts += "���ﳤ����δ����";
            ts += "��ʹ���Ƿɽ��ڣ�";
            ts += "���̺������ɽ��";

            // ���ִ�����Ҫ�ֲ��������ı���������ÿ��ʫ�����������
            CharacterRange[] charRanges = new CharacterRange[] 
		{ 
			new CharacterRange(4, 3),
			new CharacterRange(12, 3),
			new CharacterRange(20, 3), 
			new CharacterRange(28, 3)
		};

            // �����ı�ʱʹ�õ����弰��С 
            FontFamily fontFamily = new FontFamily("������κ");
            Font myFont = new Font(fontFamily, 25, FontStyle.Italic, GraphicsUnit.Pixel);

            StringFormat strFormat = new StringFormat();
            //ָ����Ҫ�ֲ��������������
            Region[] CharRangeRegions = new Region[4];

            //�������ʽ��������Ҫ�ֲ�����������
            strFormat.SetMeasurableCharacterRanges(charRanges);

            //�ھ���layoutRect_A�ж��ı����оֲ������������Ľ��������CharRangeRegions��
            CharRangeRegions = graphics.MeasureCharacterRanges(ts, myFont, layoutRect_A, strFormat);
            //����ı�
            graphics.DrawString(ts,
                myFont, TextBrush, layoutRect_A, strFormat);
            //�����ı�����߿�
            graphics.DrawRectangle(blackPen,
                layoutRect_A.X, layoutRect_A.Y, layoutRect_A.Width, layoutRect_A.Height);
            short i;
            //�����CharRangeRegions���������
            for (i = 0; i < 4; i++)
            {
                graphics.FillRegion(RegionBrush, CharRangeRegions[i]);
            }

            //�ھ���layoutRect_B�ж��ı����оֲ������������Ľ��������CharRangeRegions��
            CharRangeRegions = graphics.MeasureCharacterRanges(ts, myFont, layoutRect_B, strFormat);
            //����ı�
            graphics.DrawString(ts, myFont, TextBrush, layoutRect_B, strFormat);
            graphics.DrawRectangle(blackPen,
                layoutRect_B.X, layoutRect_B.Y, layoutRect_B.Width, layoutRect_B.Height);
            //�������
            for (i = 0; i < 4; i++)
            {
                graphics.FillRegion(RegionBrush, CharRangeRegions[i]);
            }

            //�ھ���layoutRect_c�ж��ı����оֲ������������Ľ��������CharRangeRegions��
            CharRangeRegions = graphics.MeasureCharacterRanges(ts, myFont, layoutRect_C, strFormat);
            //����ı�
            graphics.DrawString(ts, myFont, TextBrush, layoutRect_C, strFormat);
            graphics.DrawRectangle(blackPen,
                layoutRect_C.X, layoutRect_C.Y, layoutRect_C.Width, layoutRect_C.Height);
            //�������
            for (i = 0; i < 4; i++)
            {
                graphics.FillRegion(RegionBrush, CharRangeRegions[i]);
            }

        }
        //�ؼ��ı��������
        private void Font_TextoutDirection_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //�����Ҫ������ִ�
            string ts = "��ʱ���º�ʱ�أ�";
            ts += "���ﳤ����δ����";
            ts += "��ʹ���Ƿɽ��ڣ�";
            ts += "���̺������ɽ��";

            //�����������
            FontFamily fontFamily = new FontFamily("��Բ");
            Font myFont = new Font(fontFamily, 20, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush brush = new SolidBrush(Color.Red);
            Pen pen = new Pen(Color.Black);

            //�����������
            Rectangle f = new Rectangle(10, 10, 120, myFont.Height * 8);
            //����StringFormat����
            StringFormat strFormat = new StringFormat();
            //����������ı�
            StringFormatFlags flag = StringFormatFlags.DirectionRightToLeft;
            //�ı�����ֱ���������
            flag |= StringFormatFlags.DirectionVertical;
            //���������ʽ��־
            strFormat.FormatFlags = flag;

            //�����ı����뷽ʽ
            strFormat.Alignment = StringAlignment.Center;
            strFormat.LineAlignment = StringAlignment.Center;

            //����������估�ı�
            graphics.DrawRectangle(pen, f);
            graphics.DrawString(ts, myFont, brush, f, strFormat);
        }
        //�����ı����뷽ʽ
        private void Font_TextAlignment_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //����ǰ���ڴ�С��Ϣ����
            Rectangle rect = new Rectangle(0, 0,
                this.ClientSize.Width, this.ClientSize.Height);
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Gray);

            //�Ե�ǰ�������ĵ�Ϊԭ�����������
            graphics.DrawLine(pen,
                new PointF(rect.Width / 2, 0), new PointF(rect.Width / 2, rect.Height));
            graphics.DrawLine(pen,
                new PointF(0, rect.Height / 2), new PointF(rect.Width, rect.Height / 2));

            //��StringAlignmentö�ٵ����ֲ�ͬ�Ķ��뷽ʽ���ó������Ա���Ա�ֱ�ӷ���
            StringAlignment[] Align = new StringAlignment[3]
		{
			StringAlignment.Near,
			StringAlignment.Center,
			StringAlignment.Far
		};
            string[] strAlign = new string[] { "��", "��", "Զ" };

            //�����������
            FontFamily fontFamily = new FontFamily("��Բ");
            Font font = new Font(fontFamily, 12, FontStyle.Regular);
            StringFormat strfmt = new StringFormat();

            //�ֱ��ڴ�ֱ��ˮƽ������ʹ�����ֲ�ͬ�Ķ��뷽ʽ
            for (int iVert = 0; iVert < 3; iVert++)
                for (int iHorz = 0; iHorz < 3; iHorz++)
                {
                    //���ô�ֱ���뷽ʽ
                    strfmt.LineAlignment = (StringAlignment)Align[iVert];
                    //����ˮƽ���뷽ʽ
                    strfmt.Alignment = (StringAlignment)Align[iHorz];
                    //��������Ϣ���
                    string s = string.Empty;
                    s = string.Format("ˮƽ����:{0}\n��ֱ����:{1}",
                        strAlign[iVert], strAlign[iHorz]);

                    //�ڵ�ǰ�����а������õĶ��뷽ʽ�����ı�
                    graphics.DrawString(s, font, brush, rect, strfmt);
                }
        }

        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }



        private void Form1_Resize(object sender, System.EventArgs e)
        {
            ////this.Invalidate();
        }

        private void Font_TextAlignment2_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //����ǰ���ڴ�С��Ϣ����
            Rectangle rect = new Rectangle(0, 0,
                this.ClientSize.Width, this.ClientSize.Height);
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Gray);

            //�Ե�ǰ�������ĵ�Ϊԭ�����������
            graphics.DrawLine(pen,
                new PointF(rect.Width / 2, 0), new PointF(rect.Width / 2, rect.Height));
            graphics.DrawLine(pen,
                new PointF(0, rect.Height / 2), new PointF(rect.Width, rect.Height / 2));

            //��StringAlignmentö�ٵ����ֲ�ͬ�Ķ��뷽ʽ���ó������Ա���Ա�ֱ�ӷ���
            StringAlignment[] Align = new StringAlignment[3]
		{
			StringAlignment.Near,
			StringAlignment.Center,
			StringAlignment.Far
		};
            string[] strAlign = new string[] { "��", "��", "Զ" };

            //�����������
            FontFamily fontFamily = new FontFamily("��Բ");
            Font font = new Font(fontFamily, 12, FontStyle.Regular);
            StringFormat strfmt = new StringFormat();

            //�ֱ��ڴ�ֱ��ˮƽ������ʹ�����ֲ�ͬ�Ķ��뷽ʽ
            for (int iVert = 0; iVert < 3; iVert += 2)
                for (int iHorz = 0; iHorz < 3; iHorz += 2)
                {
                    //���ô�ֱ���뷽ʽ
                    strfmt.LineAlignment = (StringAlignment)Align[iVert];
                    //����ˮƽ���뷽ʽ
                    strfmt.Alignment = (StringAlignment)Align[iHorz];
                    //��������Ϣ���
                    string s = string.Empty;
                    s = string.Format("ˮƽ����:{0}\n��ֱ����:{1}",
                        strAlign[iVert], strAlign[iHorz]);

                    //�ڵ�ǰ�����а������õĶ��뷽ʽ�����ı�
                    graphics.DrawString(s, font, brush, new PointF(this.ClientSize.Width / 2, this.ClientSize.Height / 2), strfmt);
                }
        }
        //ʹ���Ʊ�λ
        private void Font_TextoutUsingTabs_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            StringFormat stringFormat = new StringFormat();
            //����ı�ʹ�õ�����
            FontFamily fontFamily = new FontFamily("Arial");
            Font font = new Font(fontFamily, 30, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush solidBrush = new SolidBrush(Color.Black);

            //��ʹ���Ʊ�λ��Ϣ�����
            string text = "A\tB\tC\t\t\tD";
            graphics.DrawString(text, font, solidBrush, new PointF(0, 10), stringFormat);

            //�����Ʊ�λ��Ϣ1
            float[] tabs = new float[] { 40.0f, 30.0f, 40 };
            stringFormat.SetTabStops(0.0f, tabs);

            //ʹ���Ʊ�λ��Ϣ�Ľ����ı����
            graphics.TranslateTransform(0, 30);
            text = "A\tB\tC\tD";
            graphics.DrawString(text, font, solidBrush, new PointF(0, 10), stringFormat);

            //�����Ʊ�λ��Ϣ2
            float[] tabs2 = { 60.0f, 60.0f, 60 };
            stringFormat.SetTabStops(0.0f, tabs2);
            graphics.TranslateTransform(0, 30);
            graphics.DrawString(text, font, solidBrush, new PointF(0, 10), stringFormat);

            //��ȡ�Ʊ���Ϣ	
            float firstTabOffset = 0;
            float[] tabStops = stringFormat.GetTabStops(out firstTabOffset);

            //����Ʊ�λ
            for (int j = 0; j < 3; ++j)
                tabStops[j] = 0;
            stringFormat.SetTabStops(0.0f, tabStops);

            //������Ʊ�λ��Ϣ������ı�
            graphics.TranslateTransform(0, 30);
            graphics.DrawString(text, font, solidBrush, new PointF(0, 10), stringFormat);
        }

        //������Ʒ��Ϣ�ṹ
        struct SListItem
        {
            public string name;//��Ʒ��
            public float price;//����
            public float num;//����
            //���绯
            public SListItem(string p1, float p2, float p3)
            {
                name = p1;
                price = p2;
                num = p3;
            }
        };
        private void Font_UsingTabs_Click(object sender, System.EventArgs e)
        {

            //��ʼ����Ʒ��Ϣ
            SListItem[] items = new SListItem[5];
            items[0] = new SListItem("MP3���Ż�", 1228, 10);
            items[1] = new SListItem("�ʼǱ�����", 17200, 1);
            items[2] = new SListItem("�����ӡ��", 3200, 5);
            items[3] = new SListItem("��ī��ӡ��", 620, 1);
            items[4] = new SListItem("�������", 4800, 5);

            //�����ͷ
            string title = string.Empty;
            title = string.Format("\n{0}\t{1}\t{2}\t{3}\n", "��Ʒ��", "����", "����", "�ܼ�");
            //��ʽ��ÿ����Ʒ��Ӧ���ַ���
            string[] iteminfo = new string[5];
            for (int i = 0; i < 5; i++)
            {
                //�����ܼ�
                float total = items[i].price * items[i].num;
                //���������ʽ
                string s = string.Empty;
                s = string.Format("{0}\t{1:F2}\t{2:F2}\t{3:F2}\n",
                    items[i].name, items[i].price, items[i].num, total);
                iteminfo[i] = s;
            }

            //�ڱ��ÿһ�е����ݺϲ�
            string xxx = string.Empty; ;
            for (int i = 0; i < 5; i++)
                xxx += iteminfo[i];
            //��ͷ+����
            title += xxx;

            //�ڵ�ǰ������������
            RectangleF rect = new RectangleF(0.0f, 0.0f,
                this.ClientSize.Width, this.ClientSize.Height);

            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush solidBrush = new SolidBrush(Color.Black);
            //�����������
            FontFamily fontFamily = new FontFamily("����");
            Font font = new Font(fontFamily,
                16, FontStyle.Regular, GraphicsUnit.Pixel);

            StringFormat stringFormat = new StringFormat();
            //�����Ʊ�λ��Ϣ
            float[] tabs = new float[] { 120.0f, 120.0f, 60.0f };
            stringFormat.SetTabStops(0.0f, tabs);
            //������
            graphics.DrawString(title, font, solidBrush, rect, stringFormat);
        }

        private void Font_TextoutHotkeyPrefix_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush solidBrush = new SolidBrush(Color.Black);
            FontFamily fontFamily = new FontFamily("����");
            Font font = new Font(fontFamily, 20, FontStyle.Regular, GraphicsUnit.Pixel);
            Pen pen = new Pen(Color.Red);

            StringFormat stringFormat = new StringFormat();
            //��ʾ��ݼ��ַ���������"&"��
            stringFormat.HotkeyPrefix = HotkeyPrefix.None;
            graphics.DrawString("������(&T )\n״̬��(&S )", font, solidBrush,
                new RectangleF(30, 30, 160, font.Height * 2), stringFormat);

            //���Ʊ߿�
            graphics.DrawRectangle(pen, new Rectangle(30, 30, 160, font.Height * 2));

            //����""��Ϊ�»���
            stringFormat.HotkeyPrefix = HotkeyPrefix.Show;
            graphics.TranslateTransform(0, font.Height * 3);
            graphics.DrawString("������(&T )\n״̬��(&S )", font, solidBrush,
                new RectangleF(30, 30, 160, font.Height * 2), stringFormat);

            //���Ʊ߿�
            graphics.DrawRectangle(pen, new Rectangle(30, 30, 160, font.Height * 2));

            //����""��
            graphics.TranslateTransform(0, font.Height * 3);
            stringFormat.HotkeyPrefix = HotkeyPrefix.Hide;
            graphics.DrawString("������(&T )\n״̬��(&S )", font, solidBrush,
                new RectangleF(30, 30, 160, font.Height * 2), stringFormat);

            graphics.DrawRectangle(pen, new Rectangle(30, 30, 160, font.Height * 2));

        }

        private void Font_TextoutShadow_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            //���ı�ʹ��ȥ��ݵı�Ե����
            graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

            FontFamily fontFamily = new FontFamily("����_GB2312_GB2312");
            Font font = new Font(fontFamily, 100, FontStyle.Bold, GraphicsUnit.Pixel);

            //�ı������
            RectangleF textout = new RectangleF(font.Height,
                this.ClientSize.Height / 2, this.ClientSize.Width, this.ClientSize.Height);

            //��������ͬ��λ�û����ı����γ���Ӱ
            //solidBrush��ɫ��͸����Ϊ100������
            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(100, Color.Black));
            SolidBrush redBrush = new SolidBrush(Color.Red);
            graphics.DrawString("��Ӱ��", font, solidBrush,
                new PointF(27.0f, 27.0f));
            graphics.DrawString("��Ӱ��", font, redBrush,
                new PointF(12.0f, 20.0f));

            //��һ����Ӱ�֣���ӰΪ����
            //����Ӱ�߻�ˢ
            HatchBrush brush_tmp = new HatchBrush(
                HatchStyle.DarkDownwardDiagonal, Color.Black, Color.White);

            int reptime = 40;
            //�Ȼ�����
            for (int i = 0; i < reptime; i++)
                graphics.DrawString("��Ӱ��", font, brush_tmp,
                    new PointF(textout.X + i + 2, textout.Y + i + 2));

            //�ٻ�ǰ��
            graphics.DrawString("��Ӱ��", font, Brushes.Red, new PointF(textout.X, textout.Y));
        }

        private void Font_TextoutHashline_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            //���ı�ʹ��ȥ��ݵı�Ե����
            graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

            FontFamily fontFamily = new FontFamily("����_GB2312_GB2312");
            Font font = new Font(fontFamily, 100, FontStyle.Bold, GraphicsUnit.Pixel);

            //�ı������
            RectangleF textout = new RectangleF(font.Height, 0, this.Width, this.Height);
            //��ˢ������ʾ��
            RectangleF brushdemo = new RectangleF(0, 0, font.Height, font.Height);
            //����һ��Ӱ�߻�ˢ
            HatchBrush brush_tmp = new HatchBrush(HatchStyle.Percent75, Color.Black, Color.White);

            //�����ı������ʽ��ˮƽ���󡢴�ֱ����
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near;
            format.LineAlignment = StringAlignment.Center;

            //��ʾ��ˢ����
            graphics.FillRectangle(brush_tmp, brushdemo);
            //ʹ�û�ˢ�����ı�
            graphics.DrawString("Ӱ����", font, brush_tmp, textout, format);

        }

        private void Font_TextoutTexture_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            //���ı�ʹ��ȥ��ݵı�Ե����
            graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

            FontFamily fontFamily = new FontFamily("GB2312");
            Font font = new Font(fontFamily, 70, FontStyle.Bold, GraphicsUnit.Pixel);

            //�ı������
            RectangleF textout = new RectangleF(0, 0,
                this.ClientSize.Width, this.ClientSize.Height);
            //��ˢ������ʾ��
            RectangleF brushdemo = new RectangleF(0, 0, font.Height, font.Height);

            //װ������ͼƬ
            Bitmap image = new Bitmap("TEXTURE3.bmp");
            //��������ˢ
            TextureBrush brush_tmp = new TextureBrush(image);

            //�����ı������ʽ��ˮƽ����ֱ����
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            //��ʾ��ˢ����
            graphics.FillRectangle(brush_tmp, brushdemo);
            //ʹ�û�ˢ�����ı�
            graphics.DrawString("������", font, brush_tmp, textout, format);
        }

        private void Font_TextoutGradient_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            //���ı�ʹ��ȥ��ݵı�Ե����
            graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

            FontFamily fontFamily = new FontFamily("����_GB2312_GB2312");
            Font font = new Font(fontFamily, 70, FontStyle.Bold, GraphicsUnit.Pixel);

            RectangleF textout = new RectangleF(0, 0,
                this.ClientSize.Width, this.ClientSize.Height);
            //��ˢ������ʾ��
            RectangleF brushdemo = new RectangleF(0, 0, font.Height, font.Height);
            //����һ����ɫ���仭ˢ
            Color[] colors = new Color[]
			{
				Color.Red,   // ��ɫ
				Color.Green,//����ɫΪ��ɫ
				Color.Blue  // ��ɫ
			};
            float[] positions = new float[]
			{
				0.0f,   // �ɺ�ɫ��
				0.3f,   // ��ɫʼ�ڻ�ˢ���ȵ�����֮һ
				1.0f // ����ɫֹ
			};

            //����һ���Ӻ�ɫ����ɫ�Ľ��仭ˢ
            LinearGradientBrush brush_tmp = new LinearGradientBrush(
                new Point(0, 0),
                new Point(100, font.Height),
                Color.White,         // ��
                Color.White);  // ��

            //���ý��仭ˢ�Ķ�ɫ������Ϣ
            ColorBlend clrBlend = new ColorBlend(3);
            clrBlend.Colors = colors;
            clrBlend.Positions = positions;
            brush_tmp.InterpolationColors = clrBlend;

            //�����ı������ʽ��ˮƽ���󡢴�ֱ����
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near;
            format.LineAlignment = StringAlignment.Center;
            //��ʾ��ˢ����
            graphics.FillRectangle(brush_tmp, brushdemo);
            //ʹ�û�ˢ�����ı�
            graphics.DrawString("������", font, brush_tmp, textout, format);
        }
        //����·��
        private void Path_Construct_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //���幹��·���ĵ�����
            PointF[] data = new PointF[]
		{
			new PointF(40,140),
			new PointF(275,200),
			new PointF(105,225),
			new PointF(190,300),
			new PointF(50,350),
			new PointF(20,180)
		};

            //���ö��������ͽ�ÿ�㶼�����ֱ�ߵĶ˵�
            byte[] typeline = new byte[]
	{
		(byte)PathPointType.Line,
		(byte)PathPointType.Line,
		(byte)PathPointType.Line,
		(byte)PathPointType.Line,
		(byte)PathPointType.Line,
		(byte)PathPointType.Line
	};

            //����·��
            GraphicsPath tmp1 = new GraphicsPath(data, typeline);
            //���·��
            graphics.FillPath(Brushes.Red, tmp1);

            //���ƶ���·���Ķ˵�
            for (int i = 0; i < 6; i++)
                graphics.FillEllipse(Brushes.Black,
                    new RectangleF(data[i].X - 5, data[i].Y - 5, 10, 10));

            //��ͼƽ������
            graphics.TranslateTransform(360, 0);

            //����·���Ķ˵�����
            byte[] type = new byte[]
		{
			(byte)PathPointType.Start,
			(byte)PathPointType.Bezier,
			(byte)PathPointType.Bezier,
			(byte)PathPointType.Bezier,
			(byte)PathPointType.Line,
			(byte)PathPointType.Line
		};
            //���첢���·��
            GraphicsPath tmp = new GraphicsPath(data, type);
            graphics.FillPath(Brushes.Red, tmp);

            //���ƶ���·���Ķ˵�
            for (int i = 0; i < 6; i++)
                graphics.FillEllipse(Brushes.Black,
                    new RectangleF(data[i].X - 5, data[i].Y - 5, 10, 10));
        }

        private void Path_AddLines_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 2);
            //����·������
            GraphicsPath path = new GraphicsPath();

            Rectangle rect1 = new Rectangle(20, 20, 100, 200);
            Rectangle rect2 = new Rectangle(40, 40, 100, 200);
            //������λ���
            path.AddArc(rect1, 0.0f, 180.0f);
            path.AddArc(rect2, 0.0f, 180.0f);
            graphics.DrawPath(pen, path);
        }
        //���ͼ��
        private void Path_CloseFigure_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 2);
            //����·������
            GraphicsPath path = new GraphicsPath();

            Rectangle rect1 = new Rectangle(20, 20, 100, 200);
            Rectangle rect2 = new Rectangle(40, 40, 100, 200);
            GraphicsPath path2 = new GraphicsPath();
            path2.AddArc(rect1, 0.0f, 180.0f);
            //��ջ���1
            path2.CloseFigure();
            path2.AddArc(rect2, 0.0f, 180.0f);
            //��ջ���2
            path2.CloseFigure();
            graphics.DrawPath(pen, path2);
        }
        //·�������
        private void Path_FillPath_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            GraphicsPath path1 = new GraphicsPath();
            GraphicsPath path = new GraphicsPath();
            Pen pen = new Pen(Color.FromArgb(128, Color.Blue), 5);
            SolidBrush brush = new SolidBrush(Color.Red);

            //�������ֱ�ߣ����ŵ�ͼ��
            path1.AddLine(10, 10, 10, 50);
            path1.AddLine(10, 50, 50, 50);
            path1.AddLine(50, 50, 50, 10);
            path1.StartFigure();

            //���һ���պϵ�ͼ��
            RectangleF rect = new RectangleF(110, 10, 40, 40);
            //��ʼ�ڶ�����·����ͼ��׷��
            path1.AddRectangle(rect);
            //���ơ����·��
            graphics.DrawPath(pen, path1);
            graphics.FillPath(brush, path1);

            //��ӿ��ŵĻ���
            path.AddArc(0, 0, 150, 120, 30, 120);
            //��ӷ�յ���Բ
            path.AddEllipse(50, 50, 50, 100);

            //ʹ��Ĭ�ϵ���䷽ʽ���·��
            graphics.FillPath(brush, path);
            graphics.DrawPath(pen, path);
        }

        private void Path_AddSubPath_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 2);
            Rectangle rect = new Rectangle(0, 0, 100, 50);
            GraphicsPath path = new GraphicsPath();

            //��·���а���ֱ���������λ���
            path.AddArc(0, 0, 100, 50, 0.0f, 180.0f);
            path.AddArc(0, 30, 100, 50, 0.0f, 180.0f);
            path.AddArc(0, 60, 100, 50, 0.0f, 180.0f);
            path.AddArc(0, 90, 100, 50, 0.0f, 180.0f);
            path.AddArc(0, 120, 100, 50, 0.0f, 180.0f);
            graphics.DrawPath(pen, path);

            //��ȡ·����ռ����
            RectangleF rect2 = path.GetBounds();

            //��ͼƽ������
            graphics.TranslateTransform(rect2.Width + 10, 0);

            GraphicsPath path2 = new GraphicsPath();
            //�����һ����·��
            path2.AddArc(0, 0, 100, 50, 0.0f, 180.0f);
            path2.AddArc(0, 30, 100, 50, 0.0f, 180.0f);
            path2.AddArc(0, 60, 100, 50, 0.0f, 180.0f);

            //�ڲ���յ�ǰ��·��������¿�ʼ�ڶ�����·���Ļ���
            path2.StartFigure();
            //��ӻ���
            path2.AddArc(0, 90, 100, 50, 0.0f, 180.0f);

            //�ڷ�յ�ǰ��·��������¿�ʼ��������·���Ļ���
            path2.CloseFigure();
            path2.AddArc(0, 120, 100, 50, 0.0f, 180.0f);

            //������·��
            graphics.DrawPath(pen, path2);
        }

        private void Path_GetSubPath_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen bluePen = new Pen(Color.Blue, 3);
            GraphicsPath path = new GraphicsPath();
            // ��·��1
            path.AddRectangle(new Rectangle(20, 20, 60, 30));
            // ��·��2
            path.AddLine(100, 20, 160, 50);
            path.AddArc(180, 20, 60, 30, 0.0f, 180.0f);
            // ��·��3
            path.AddRectangle(new Rectangle(260, 20, 60, 30));
            // ��·��4
            path.AddLine(340, 20, 400, 50);
            path.AddArc(340, 20, 60, 30, 0.0f, 180.0f);
            path.CloseFigure();
            // ��·��5
            path.AddRectangle(new Rectangle(420, 20, 60, 30));
            //����·��
            graphics.DrawPath(bluePen, path);

            // ����·����������iterator
            GraphicsPathIterator iterator = new GraphicsPathIterator(path);
            GraphicsPath subpath = new GraphicsPath();
            bool isClosed = false;
            int count = 0;
            //������������NextSubpath,��ȡ��·��
            //��·���ĵ�ǰλ���ƶ���1
            count = iterator.NextSubpath(subpath, out isClosed);
            //��·���ĵ�ǰλ���ƶ���2
            count = iterator.NextSubpath(subpath, out isClosed);

            //�ڵڶ��л�����ȡ����·��
            graphics.TranslateTransform(0, 50);
            graphics.DrawPath(bluePen, subpath);

            //��λ���е�λ���ƶ���Ϣ
            iterator.Rewind();
            count = iterator.NextSubpath(subpath, out isClosed);
            //�ڵ����л����³�ȡ����·��
            graphics.TranslateTransform(0, 50);
            Pen redPen = new Pen(Color.Red, 3);
            graphics.DrawPath(redPen, subpath);

            //������������NextSubpath���Ի�ȡ��·���Ķ������Ϣ
            int start = 0;
            int end = 0;
            string msg = string.Empty;
            //��λ���е�λ���ƶ���Ϣ
            iterator.Rewind();
            count = iterator.NextSubpath(out start, out end, out isClosed);
            //����λ��������Ϣ
            msg = string.Format(
                "��һ���ƶ���·���Ķ������ֹλ��Ϊ{0}\t��\t{1}\n", start, end);
            count = iterator.NextSubpath(out start, out end, out isClosed);
            msg += string.Format(
                "�ڶ����ƶ���·���Ķ������ֹλ��Ϊ{0}\t��\t{1}\n", start, end);

            //������·���Ķ����λ��������Ϣ
            FontFamily fontFamily = new FontFamily("����");
            Font font = new Font(fontFamily, 12);
            graphics.TranslateTransform(0, 60);
            graphics.DrawString(msg, font, Brushes.Black, new PointF(0, 0));
        }

        private void Path_GetPoints_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //����·������
            GraphicsPath path = new GraphicsPath();
            //���ֱ��
            path.AddLine(20, 100, 150, 120);
            //��Ӿ���
            path.AddRectangle(new Rectangle(40, 30, 20, 60));
            //�����Բ
            path.AddEllipse(new Rectangle(70, 30, 100, 40));
            //������ߡ�
            Point[] points = new Point[]
		{
			new Point(300, 40),
			new Point(350, 60),
			new Point(300, 80),
			new Point(300, 100),
			new Point(350, 150)
		};
            path.AddCurve(points, 5);

            //����·��
            Pen pen = new Pen(Color.Blue);
            graphics.DrawPath(pen, path);

            // ��ȡ����·���ĵ�����
            int count = path.PointCount;
            //���Ƶ㶨��·���ĵ�
            SolidBrush brush = new SolidBrush(Color.Red);
            for (int j = 0; j < count; ++j)
            {
                graphics.FillEllipse(
                    brush,
                    path.PathPoints[j].X - 3.0f,
                    path.PathPoints[j].Y - 3.0f,
                    6.0f,
                    6.0f);
            }
            /*����һһ�ֱ�������ķ�ʽ
            foreach( PointF x in path.PathPoints)
                graphics.FillEllipse(
                    brush, 
                    x.X - 3.0f, 
                    x.Y - 3.0f,
                    6.0f,
                    6.0f);
            */
        }

        private void Path_PathData_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //���ߵĶ����
            Point[] points = new Point[]
		{
			new Point(40, 60), 
			new Point(50, 70), 
			new Point(30, 90)
		};

            Pen pen = new Pen(Color.Red, 2);
            GraphicsPath path = new GraphicsPath();
            //����
            path.AddArc(175, 50, 50, 50, 0.0f, -180.0f);
            //ֱ��
            path.AddLine(100, 0, 250, 20);
            path.StartFigure();
            //ֱ��
            path.AddLine(50, 20, 5, 90);
            //����
            path.AddCurve(points, 3);
            path.AddLine(50, 150, 150, 180);
            path.CloseAllFigures();
            //����·��
            graphics.DrawPath(pen, path);
            PathData pathData = new PathData();
            //��ȡPathData����ֵ
            pathData = path.PathData;
            SolidBrush brush = new SolidBrush(Color.Red);

            //���ƶ����
            foreach (PointF i in pathData.Points)
                graphics.FillEllipse(Brushes.Black,
                    i.X - 5.0f, i.Y - 5.0f, 10.0f, 10.0f);
            //���ÿһ��·������������
            int index = 1;
            FontFamily fontFamily = new FontFamily("����");
            Font font = new Font(fontFamily, 12);
            graphics.TranslateTransform(path.GetBounds().Width + 10, 0);
            foreach (PathPointType ii in pathData.Types)
            {
                string msg = string.Format("��{0}�������Ϊ:\t{1}",
                    index.ToString(), ii.ToString());
                graphics.DrawString(msg,
                    font, Brushes.Black, new PointF(0, index * font.Height));
                index++;
            }
        }

        private void Path_ViewPointFLAG_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            graphics.ScaleTransform(0.8f, 0.8f);


            SolidBrush brush = new SolidBrush(Color.Red);
            //����һ�������ĸ���·����·��
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(new Rectangle(20, 20, 60, 30));
            path.AddLine(100, 20, 160, 50);
            path.AddArc(180, 20, 60, 30, 0, 180);
            path.AddRectangle(new Rectangle(260, 20, 60, 30));
            path.AddLine(340, 20, 400, 50);
            path.AddArc(340, 20, 60, 30, 0, 180);
            path.CloseAllFigures();
            //���·��
            graphics.FillPath(brush, path);

            //��·���ı����Ϣ����GraphicsPathIterator����
            GraphicsPathIterator iterator = new GraphicsPathIterator(path);

            //��ȡ��ǵ���Ϣ
            int start = 0;
            int end = 0;
            int count = 0;
            //��ȡ��һ���������
            count = iterator.NextMarker(out start, out end);
            //Ϊ�����ꡢ���ͷ���ռ�
            PointF[] points = new PointF[count];
            byte[] types = new byte[count];
            //��iterator������Ϣ
            iterator.CopyData(ref points, ref types, start, end);
            //���ݸ��Ƶ���Ϣ�´���һ��·��
            GraphicsPath pathnew = new GraphicsPath(points, types);

            //����λ�û���·���Ķ����
            graphics.TranslateTransform(0, 60);
            for (int j = 0; j < count; ++j)
                graphics.FillEllipse(Brushes.Black, points[j].X - 2.0f,
                    points[j].Y - 2.0f, 4.0f, 4.0f);

            //����´�����·��
            graphics.TranslateTransform(0, 60);
            graphics.FillPath(brush, pathnew);
            graphics.TranslateTransform(0, 60);

            //������еı�ǵ���Ϣ
            string msg = string.Empty;
            for (int j = 0; j < count; ++j)
            {
                msg += string.Format("��{0}����Ϣ:X={1:F2}\tY={2:F2}\t����={3}\n",
                    j, points[j].X, points[j].Y, types[j].ToString());
            }

            //�����ַ���
            FontFamily fontFamily = new FontFamily("����");
            Font font = new Font(fontFamily, 12, FontStyle.Regular, GraphicsUnit.Pixel);
            graphics.DrawString(msg, font, Brushes.Black, new PointF(0, 0));

        }

        private void Path_SubPathRange_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush brush = new SolidBrush(Color.Red);
            //����һ�����������·����·��
            GraphicsPath path = new GraphicsPath();
            /*************path.SetMarkers();**************/
            //��ӵ�һ����·��
            path.AddRectangle(new Rectangle(20, 20, 60, 30));

            //��ӵڶ�����·��
            path.AddLine(100, 20, 160, 50);
            //�ڶ�����ǽ��ڶ�����·��������ض�
            path.SetMarkers();
            path.AddArc(180, 20, 60, 30, 0, 180);

            //��ӵ�������·��
            path.AddRectangle(new Rectangle(260, 20, 60, 30));
            //���������
            path.SetMarkers();

            //��ӵ��ĸ���·��
            path.AddLine(340, 20, 400, 50);
            path.AddArc(340, 20, 60, 30, 0, 180);

            //���·��
            graphics.FillPath(brush, path);

            //��·���ı����Ϣ����GraphicsPathIterator����
            GraphicsPathIterator iterator = new GraphicsPathIterator(path);
            int d = iterator.SubpathCount;
            //��ȡ��ǵ���Ϣ
            int start;
            int end;
            int count;
            //�Ƶ��ڶ������
            count = iterator.NextMarker(out start, out end);
            //�Ƶ����������
            count = iterator.NextMarker(out start, out end);
            //Ϊ�����ꡢ���ͷ���ռ�
            PointF[] points = new PointF[count];
            byte[] types = new byte[count];

            //��iterator������Ϣ
            iterator.CopyData(ref points, ref types, start, end);
            //���ݸ��Ƶ���Ϣ�´���һ��·��
            GraphicsPath pathnew = new GraphicsPath(points, types);

            //����λ�û��Ʊ�ǵ�
            graphics.TranslateTransform(0, 60);
            for (int j = 0; j < count; ++j)
                graphics.FillEllipse(Brushes.Black,
                    points[j].X - 2.0f, points[j].Y - 2.0f,
                    4.0f,
                    4.0f);

            //����´�����·��
            graphics.TranslateTransform(0, 60);
            graphics.FillPath(brush, pathnew);

            //������еı�ǵ���Ϣ
            string msg = string.Empty;
            for (int j = 0; j < count; ++j)
            {
                msg += string.Format("��{0}�����Ϣ:X={1:F2}\tY={2:F2} \t���ͣ�{3:F2}\n",
                    j, points[j].X, points[j].Y, types[j].ToString());
            }

            FontFamily fontFamily = new FontFamily("����");
            Font font = new Font(fontFamily, 12, FontStyle.Regular, GraphicsUnit.Pixel);
            //�����ַ���
            graphics.TranslateTransform(0, 60);
            graphics.DrawString(msg, font, Brushes.Black, new PointF(0, 0));
        }

        private void Path��Flatten_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //���߶����
            Point[] pts = new Point[]
		{
			new Point(20,50), 
			new Point(60,70), 
			new Point(80,10), 
			new Point(120,50)
		};

            GraphicsPath path = new GraphicsPath();
            path.AddCurve(pts, 4);
            path.AddEllipse(160, 10, 150, 80);
            path.AddBezier(20, 100, 20, 150, 50, 80, 100, 60);

            //����Ĭ�ϵķ�ʽ����·��
            Pen pen = new Pen(Color.Black, 3);
            graphics.DrawPath(pen, path);
            //��ȡ·������Ϣ
            PathData pathData = new PathData();
            pathData = path.PathData;

            // ����·�������
            SolidBrush brush = new SolidBrush(Color.Red);
            for (int j = 0; j < path.PointCount; ++j)
            {
                graphics.FillEllipse(brush, pathData.Points[j].X - 3.0f,
                    pathData.Points[j].Y - 3.0f, 6.0f, 6.0f);
            }

            //��ͼƽ������100����λ 
            graphics.TranslateTransform(0, 120);
            //��������ת  
            path.Flatten(new Matrix(), 14.0f);
            pen.Color = Color.Green;
            //����ת�����·��  
            graphics.DrawPath(pen, path);
        }

        private void Path_Warp_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            // ����һ��ȫ����������ɵ�·��
            PointF[] points = new PointF[]
		{
			new PointF(20.0f, 60.0f),
			new PointF(30.0f, 90.0f),
			new PointF(15.0f, 110.0f),
			new PointF(15.0f, 145.0f),
			new PointF(55.0f, 145.0f),
			new PointF(55.0f, 110.0f),
			new PointF(40.0f, 90.0f),
			new PointF(50.0f, 60.0f)
		};

            GraphicsPath path = new GraphicsPath();
            path.AddLines(points);
            path.CloseFigure();

            // ����Ť��ǰ��·��
            Pen bluePen = new Pen(Color.Blue, 3);
            graphics.DrawPath(bluePen, path);

            // �������·����Դ����
            RectangleF srcRect = new RectangleF(10.0f, 50.0f, 50.0f, 100.0f);
            //�������ӳ���Ŀ���
            PointF[] destPts = new PointF[]
		{
			new PointF(220.0f, 10.0f),
			new PointF(280.0f, 10.0f),
			new PointF(100.0f, 150.0f),
			new PointF(300.0f, 150.0f)
		};

            //Ť������
            path.Warp(destPts, srcRect);
            // ����Ť�����·��
            graphics.DrawPath(bluePen, path);

            // ����Դ���κ�Ŀ��Ķ����
            Pen blackPen = new Pen(Color.Black, 1);
            graphics.DrawRectangle(blackPen,
                srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height);
            graphics.DrawLine(blackPen, destPts[0], destPts[1]);
            graphics.DrawLine(blackPen, destPts[0], destPts[2]);
            graphics.DrawLine(blackPen, destPts[1], destPts[3]);
            graphics.DrawLine(blackPen, destPts[2], destPts[3]);
        }

        private void Path_Transform_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            GraphicsPath path = new GraphicsPath();
            //���һ��������·��   
            path.AddRectangle(new Rectangle(40, 10, 200, 50));
            //��������任ǰ��·��
            graphics.DrawPath(new Pen(Color.Blue, 4), path);

            //��ת·��
            Matrix matrix = new Matrix();
            matrix.Rotate(15.0f);
            path.Transform(matrix);
            //���ƽ�������任���·��
            graphics.DrawPath(new Pen(Color.Red, 4), path);
        }

        private void Path_Widen_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen bluePen = new Pen(Color.Blue, 1);
            Pen greenPen = new Pen(Color.Green, 10);
            //��������
            PointF[] points =
		{
			new PointF(10.0f, 10.0f),
			new PointF(130.0f, 90.0f),
			new PointF(140.0f, 60.0f),
			new PointF(60.0f, 90.0f)
		};

            GraphicsPath path = new GraphicsPath();
            //�����������
            path.AddClosedCurve(points, 4);

            //����������ͬ��·�����������ؿ���
            GraphicsPath path2 = new GraphicsPath();
            GraphicsPath path3 = new GraphicsPath();
            GraphicsPath path4 = new GraphicsPath();
            path2 = (GraphicsPath)path.Clone();
            path3 = (GraphicsPath)path.Clone();
            path4 = (GraphicsPath)path.Clone();

            //ʹ�ÿ��Ϊ10�Ļ��ʻ���·��
            graphics.DrawPath(new Pen(Color.Blue, 10), path);
            RectangleF rect = path.GetBounds();

            //ʹ����ɫ�����ؿ�·������
            path2.Widen(greenPen);
            //��ͼƽ�����ƣ������ؿ��·��
            graphics.TranslateTransform(rect.Width + 10, 0);
            graphics.DrawPath(bluePen, path2);

            //����
            graphics.TranslateTransform(-rect.Width, rect.Height);
            //ʹ�ü���߷�����ɫ�����ؿ�·��
            greenPen.DashStyle = DashStyle.Dash;
            path3.Widen(greenPen);
            //���·��
            graphics.FillPath(Brushes.Red, path3);

            //�Ի��ʽ������ű任 
            Pen pentmp = new Pen(Color.Blue);
            pentmp.ScaleTransform(3.0f, 20.0f);
            path4.Widen(pentmp);
            //��ͼƽ������
            graphics.TranslateTransform(rect.Width, 0);
            graphics.DrawPath(bluePen, path4);

        }

        private void Path_WidenDemo_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen bluePen = new Pen(Color.Blue, 1);
            Pen greenPen = new Pen(Color.Green, 20);
            GraphicsPath path = new GraphicsPath();
            //���һ��ֱ��
            path.AddLine(10, 20, 100, 20);
            GraphicsPath path2 = (GraphicsPath)path.Clone();

            PathData pathData = new PathData();
            PathData pathData2 = new PathData();

            pathData = path.PathData;
            int num1 = path.PointCount;

            //����·���Ķ������Ϣ
            string msg = string.Empty;
            for (int i = 0; i < num1; i++)
            {

                msg += string.Format("��{0}������ֱ�Ϊ��X={1:F2}\tY={2:F2}\n",
                    i, pathData.Points[i].X, pathData.Points[i].Y);
            }
            //����·��
            graphics.DrawPath(new Pen(Color.Blue), path);

            //ʹ����ɫ�����ؿ�·������
            path2.Widen(greenPen);
            pathData2 = path2.PathData;
            int num2 = path2.PointCount;

            //��ͼƽ�����ƣ������ؿ��·��
            RectangleF rect = path.GetBounds();
            graphics.TranslateTransform(rect.Width * 2, 0);
            graphics.DrawPath(bluePen, path2);
            graphics.ResetTransform();
            //�����ؿ��·���Ķ������Ϣ
            string msg2 = string.Empty;
            for (int i = 0; i < num2; i++)
            {
                msg2 += string.Format("�ؿ���·����{0}������ֱ�Ϊ��X={1:F2}\tY={2:F2}\n",
                    i, pathData2.Points[i].X, pathData2.Points[i].Y);
            }

            //���·���ؿ�ǰ��Ķ��������λ����Ϣ
            FontFamily fontFamily = new FontFamily("����");
            Font font = new Font(fontFamily, 12, FontStyle.Regular, GraphicsUnit.Pixel);
            graphics.TranslateTransform(0, 120);
            graphics.DrawString(msg, font, Brushes.Black, new PointF(0, 0));
            graphics.TranslateTransform(0, font.Height * (num1 + 1));
            graphics.DrawString(msg2, font, Brushes.Black, new PointF(0, 0));

        }

        private void Region��FromPath_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            //�趨�ı��������
            graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            FontFamily fontFamily = new FontFamily("����_GB2312");
            //����·������
            GraphicsPath path = new GraphicsPath();

            //��������׷���ı�
            path.AddString("��������", fontFamily,
                (int)FontStyle.Regular, 100.0f, new Point(0, 0), new StringFormat());

            Pen pen = new Pen(Color.Red);
            //����·��
            graphics.DrawPath(pen, path);
            graphics.TranslateTransform(0, 80);
            //��·���й�������
            Region region = new Region(path);
            //�������	
            graphics.FillRegion(Brushes.Red, region);
        }

        private void Region_Calculate_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            FontFamily fontFamily = new FontFamily("����");
            Font font = new Font(fontFamily, 16, FontStyle.Regular, GraphicsUnit.Pixel);

            SolidBrush solidBrush2 = new SolidBrush(Color.Red);
            SolidBrush solidBrush = new SolidBrush(Color.Green);
            Pen pen = new Pen(Color.Cyan);

            //�������εĶ˵�����
            Point[] points = new Point[]
		{
			new Point(75, 0), 
			new Point(100, 50), 
			new Point(150, 50), 
			new Point(112, 75),
			new Point(150, 150), 
			new Point(75, 120), 
			new Point(10, 150), 
			new Point(37, 75), 
			new Point(0, 50), 
			new Point(50, 50),
			new Point(75, 0)
		};

            //����·�����������
            GraphicsPath path = new GraphicsPath();
            path.AddLines(points);

            //��С·��
            Matrix matrix = new Matrix();
            matrix.Scale(0.5f, 0.5f);
            path.Transform(matrix);

            //��ȡ·����ռ�ľ�������
            RectangleF tmp = path.GetBounds();

            //��������2
            RectangleF rect = new RectangleF(0, 10, tmp.Width, 50);
            //�����ı���Ϣ�������
            RectangleF textout = new RectangleF(0, tmp.Height, tmp.Width, font.Height * 2);

            //�����ı������ʽ��ˮƽ���С���ֱ����
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Far;

            //���·�� 
            graphics.FillPath(solidBrush2, path);

            graphics.TranslateTransform(tmp.Width + 10, 0);
            //������ 
            graphics.FillRectangle(solidBrush, rect);

            //��·���д�������
            Region region = new Region(path);

            //�󽻼�
            region.Intersect(rect);
            graphics.TranslateTransform(tmp.Width + 10, 0);
            //��佻��
            graphics.FillRegion(solidBrush2, region);
            graphics.DrawString("����", font, Brushes.Black, textout, format);
            //����·����ռ�ľ�������
            graphics.DrawRectangle(pen, tmp.X, tmp.Y, tmp.Width, tmp.Height);

            //�󲢼�
            Region region2 = new Region(path);
            region2.Union(rect);
            graphics.TranslateTransform(tmp.Width + 10, 0);
            graphics.FillRegion(solidBrush2, region2);
            graphics.DrawString("����", font, solidBrush, textout, format);
            //����·����ռ�ľ�������
            graphics.DrawRectangle(pen, tmp.X, tmp.Y, tmp.Width, tmp.Height);

            //�����������������
            graphics.TranslateTransform(-(tmp.Width + 10) * 3, tmp.Height + textout.Height);

            //���첢��
            Region region3 = new Region(path);
            region3.Xor(rect);
            //����첢��
            graphics.FillRegion(solidBrush2, region3);
            graphics.DrawString("�첢��", font, Brushes.Black, textout, format);
            //����·����ռ�ľ�������
            graphics.DrawRectangle(pen, tmp.X, tmp.Y, tmp.Width, tmp.Height);

            //�󲹼�
            Region region4 = new Region(path);
            region4.Complement(rect);
            graphics.TranslateTransform(tmp.Width + 10, 0);
            //��䲹��
            graphics.FillRegion(solidBrush2, region4);
            graphics.DrawString("����", font, Brushes.Black, textout, format);
            //����·����ռ�ľ�������
            graphics.DrawRectangle(pen, tmp.X, tmp.Y, tmp.Width, tmp.Height);

            //���ų⼯
            Region region5 = new Region(path);
            region5.Exclude(rect);
            graphics.TranslateTransform(tmp.Width + 10, 0);
            //���ų⼯
            graphics.FillRegion(solidBrush2, region5);
            graphics.DrawString("�ų⼯", font, Brushes.Black, textout, format);
            graphics.DrawRectangle(pen, tmp.X, tmp.Y, tmp.Width, tmp.Height);
        }

        private void Region_GetRects_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush solidBrush = new SolidBrush(Color.Red);
            Pen pen = new Pen(Color.Black);
            GraphicsPath path = new GraphicsPath();
            Matrix matrix = new Matrix();

            //��·���д�������
            path.AddEllipse(10, 0, 80, 120);
            Region pathRegion = new Region(path);
            //�������
            graphics.FillRegion(solidBrush, pathRegion);

            //��ȡ·���ľ�����ɼ���Ϣ����ʹ�ñ任��
            RectangleF[] rects = pathRegion.GetRegionScans(matrix);
            //����ƽ�����ƣ��Ի��ƾ��μ������еľ���
            graphics.TranslateTransform(90, 0);
            foreach (RectangleF rect in rects)
                graphics.DrawRectangle(pen,
                    rect.X, rect.Y, rect.Width, rect.Height);

            //ʵʩ�任
            matrix.Scale(1.0f, 0.75f);
            matrix.Shear(0.2f, 0.3f);
            //��ȡ·���ľ�����ɼ���Ϣ��ʹ�ñ任��
            rects = pathRegion.GetRegionScans(matrix);

            //����ƽ�����ƣ��Ի��Ʊ任��ľ��μ�
            graphics.TranslateTransform(90, 0);
            foreach (RectangleF rect in rects)
                graphics.DrawRectangle(pen, rect.X, rect.Y, rect.Width, rect.Height);

        }

        private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //���øöγ���ʱ���뽫һ�����ע�͵�
            return;
            //���������δ���£��������� 
            if (e.Button != MouseButtons.Left)
                return;

            Graphics graphics = this.CreateGraphics();
            //����·������	
            PointF[] points = new PointF[]
		{
			new PointF(20.0f, 20.0f),
			new PointF(160.0f, 100.0f),
			new PointF(140.0f, 60.0f),
			new PointF(60.0f, 100.0f)
		};

            //����·������������
            GraphicsPath path = new GraphicsPath();
            path.AddClosedCurve(points);
            //�Ŵ�·��
            Matrix matrix = new Matrix();
            matrix.Scale(2.0f, 1.0f);
            path.Transform(matrix);

            //��·���д�������
            Region pathRegion = new Region(path);
            graphics.FillRegion(Brushes.Blue, pathRegion);

            //����ǰ���λ�ý��в���
            Point test = new Point(e.X, e.Y);
            //����������ڣ�������
            if (pathRegion.IsVisible(test, graphics))
                return;

            //����������⣬����Բ��
            SolidBrush brush = new SolidBrush(Color.Black);
            graphics.FillEllipse(brush, test.X - 4, test.Y - 4, 8, 8);
        }

        private void Transform_Click(object sender, System.EventArgs e)
        {
            Graphics myGraphics = this.CreateGraphics();
            myGraphics.Clear(Color.White);

            SolidBrush mySolidBrush1 = new SolidBrush(Color.Blue);
            SolidBrush mySolidBrush2 = new SolidBrush(Color.FromArgb(155, Color.Chocolate));
            GraphicsPath myGraphicsPath = new GraphicsPath();
            Rectangle myRect = new Rectangle(60, 60, 60, 60);
            //��·������Ӿ���
            myGraphicsPath.AddRectangle(myRect);
            //���·��
            myGraphics.FillPath(mySolidBrush1, myGraphicsPath);

            // ��������任
            Matrix myPathMatrix = new Matrix();
            //ˮƽ����������������ֱ���򱣳ֲ���
            myPathMatrix.Scale(2, 1);
            myPathMatrix.Rotate(30.0f);
            //��·��ʵ������任
            myGraphicsPath.Transform(myPathMatrix);

            //���任���·��
            myGraphics.FillPath(mySolidBrush2, myGraphicsPath);
        }

        private void TranslateTransform_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //װ��ͼƬ
            Bitmap image = new Bitmap("nemo.bmp");
            //����ͼƬ����ʾ����
            Rectangle rect = new Rectangle(0, 0, 110, 70);
            for (int i = 0; i < 10; i++)
            {
                //��ʾͼƬ
                graphics.DrawImage(image, rect);
                //��ͼƽ�����ƣ�ÿ����ˮƽ��������110������
                graphics.TranslateTransform(110, 0);

            }

        }

        private void RotateTransform_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //װ��ͼƬ
            Bitmap image = new Bitmap("nemo.bmp");

            //��ȡ��ǰ���ڵ����ĵ�
            Rectangle rect = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            PointF center = new PointF(rect.Width / 2, rect.Height / 2);

            float offsetX = 0;
            float offsetY = 0;
            offsetX = center.X - image.Width / 2;
            offsetY = center.Y - image.Height / 2;
            //����ͼƬ��ʾ����:��ͼƬ�����ĵ��봰�ڵ����ĵ�һ��
            RectangleF picRect = new RectangleF(offsetX, offsetY, image.Width, image.Height);
            PointF Pcenter = new PointF(picRect.X + picRect.Width / 2,
                picRect.Y + picRect.Height / 2);

            //��ͼƬ��������תһ��
            for (int i = 0; i < 361; i += 10)
            {
                // ��ͼƽ����ͼƬ�����ĵ���ת
                graphics.TranslateTransform(Pcenter.X, Pcenter.Y);
                graphics.RotateTransform(i);
                //�ָ���ͼƽ����ˮƽ�ʹ�ֱ�����ƽ��
                graphics.TranslateTransform(-Pcenter.X, -Pcenter.Y);
                //����ͼƬ����ʱ
                graphics.DrawImage(image, picRect);
                Thread.Sleep(100);
                //���û�ͼƽ������б任
                graphics.ResetTransform();
            }
        }

        private void DrawWatch_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Rectangle clientrect = new Rectangle(0, 0,
                this.ClientSize.Width, this.ClientSize.Height);

            //����·���ĸߺͿ�
            float WIDTH = clientrect.Width / 2;
            float HEIGHT = clientrect.Height / 2;

            //�����ı�������
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            FontFamily fontFamily = new FontFamily("Times New Roman");
            Font font = new Font(fontFamily, 14, FontStyle.Bold, GraphicsUnit.Pixel);

            //����ͼƽ�������ԭ���Ƶ���������
            graphics.TranslateTransform(WIDTH / 2, HEIGHT / 2);
            //�����Ǳ���
            graphics.FillEllipse(Brushes.Black,
                HEIGHT / -2, HEIGHT / -2, HEIGHT, HEIGHT);
            //����ı�
            graphics.DrawString("����/Сʱ", font, Brushes.Green,
                new PointF(-26, HEIGHT / -4 - font.Height));

            //���ƿ̶ȱ��
            graphics.RotateTransform(225);
            for (int x = 0; x < 55; x++)
            {
                graphics.FillRectangle(Brushes.Green,
                    -2, (HEIGHT / 2 - 2) * -1, 3, 15);
                graphics.RotateTransform(5);
            }

            //���û�ͼƽ�������任
            graphics.ResetTransform();

            graphics.TranslateTransform(WIDTH / 2, HEIGHT / 2);
            graphics.RotateTransform(225);
            int sp = 0;
            string tmp = string.Empty;
            //���ƿ̶�ֵ(������)
            for (int x = 0; x < 7; x++)
            {
                tmp = string.Format("{0}", sp);

                //���ƺ�ɫ�̶�
                graphics.FillRectangle(Brushes.Red, -3, (HEIGHT / 2 - 2) * -1, 6, 25);
                //������ֵ
                graphics.DrawString(tmp, font, Brushes.Green, new PointF(tmp.Length * (-6),
                    (HEIGHT / -2) + 25));
                //��ת45��
                graphics.RotateTransform(45);
                sp += 20;
            }

            //���û�ͼƽ�������任
            graphics.ResetTransform();
            graphics.TranslateTransform(WIDTH / 2, HEIGHT / 2);

            //����ָ����30����/�������
            float angle = 30 * 2.25f + 225;
            graphics.RotateTransform((float)angle);

            Pen pen = new Pen(Color.Blue, 14);
            //������ñ
            pen.EndCap = LineCap.ArrowAnchor;
            pen.StartCap = LineCap.RoundAnchor;
            //��ָ��
            graphics.DrawLine(pen, new PointF(0, 0), new PointF(0, (-1) * (HEIGHT / 2.75F)));

            graphics.ResetTransform();
            graphics.TranslateTransform(WIDTH / 2, HEIGHT / 2);
            //�������ĵ�
            graphics.FillEllipse(Brushes.Black, -6, -9, 14, 14);
            graphics.FillEllipse(Brushes.Red, -7, -7, 14, 14);

            //�����ٶȼ��ޱ��
            pen.Width = 4;
            pen.Color = Color.Black;
            pen.EndCap = LineCap.Round;
            pen.StartCap = LineCap.Flat;
            graphics.DrawLine(pen, new PointF(HEIGHT / 15.75F, HEIGHT / 3.95F),
                new PointF(HEIGHT / 10.75F, HEIGHT / 5.2F));
            pen.Color = Color.Red;
            graphics.DrawLine(pen, new PointF(HEIGHT / 15.75F, HEIGHT / 3.95F),
                new PointF(HEIGHT / 15.75F, HEIGHT / 4.6F));
        }

        private void ScaleTransform_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Rectangle clientrect = new Rectangle(0, 0,
                this.ClientSize.Width, this.ClientSize.Height);
            //��ȡ��ǰ���ڵ����ĵ�
            float width = clientrect.Width / 2;
            float height = clientrect.Height / 2;
            PointF center = new PointF(width, height);

            //���þ��γ�ʼ��СΪ30*30
            float offsetX = center.X - 15;
            float offsetY = center.Y - 15;

            //������ε���������:�þ��ε����ĵ��봰�ڵ����ĵ�һ��
            RectangleF rotateRect = new RectangleF(offsetX, offsetY, 30, 30);
            PointF Pcenter = new PointF(rotateRect.X + rotateRect.Width / 2,
                rotateRect.Y + rotateRect.Height / 2);

            //���ó�ʼ���ű���
            int scale = 1;
            //�Ծ���rotateRect��ת360�Ȳ����ϷŴ����
            for (int i = 0; i < 360; i += 60)
            {
                // ��ͼƽ����ͼƬ�����ĵ���ת
                graphics.TranslateTransform(Pcenter.X, Pcenter.Y);
                //��ˮƽ�ʹ�ֱ������ͬʱ�������
                graphics.ScaleTransform(scale, scale);
                graphics.RotateTransform(i);
                //�ָ���ͼƽ����ˮƽ�ʹ�ֱ�����ƽ��
                graphics.TranslateTransform(-Pcenter.X, -Pcenter.Y);
                //���ƾ��β���ʱ
                graphics.DrawRectangle(Pens.Black,
                    rotateRect.X, rotateRect.Y, rotateRect.Width, rotateRect.Height);
                Thread.Sleep(100);
                //���û�ͼƽ������б任
                graphics.ResetTransform();
                scale++;
            }
        }

        private void RectScale_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Rectangle clientrect = new Rectangle(0, 0,
                this.ClientSize.Width, this.ClientSize.Height);
            //��ȡ��ǰ���ڵ����ĵ�
            float width = clientrect.Width / 2;
            float height = clientrect.Height / 2;
            PointF center = new PointF(width, height);

            //���þ��γ�ʼ��СΪ30*30
            float offsetX = center.X - 15;
            float offsetY = center.Y - 15;

            //������ε���������:�þ��ε����ĵ��봰�ڵ����ĵ�һ��
            RectangleF rotateRect = new RectangleF(offsetX, offsetY, 30, 30);
            PointF Pcenter = new PointF(rotateRect.X + rotateRect.Width / 2,
                rotateRect.Y + rotateRect.Height / 2);

            //���ó�ʼ���ű���
            int scale = 0;
            //�Ծ���rotateRect��ת360�Ȳ����ϷŴ����
            for (int i = 0; i < 361; i += 60)
            {
                // ��ͼƽ����ͼƬ�����ĵ���ת
                graphics.TranslateTransform(Pcenter.X, Pcenter.Y);
                //��ˮƽ�ʹ�ֱ������ͬʱ���Ӿ��εĿ�Ⱥ͸߶�
                rotateRect.Inflate(scale * 15, scale * 15);
                graphics.RotateTransform(i);
                //�ָ���ͼƽ����ˮƽ�ʹ�ֱ�����ƽ��
                graphics.TranslateTransform(-Pcenter.X, -Pcenter.Y);
                //����ͼƬ����ʱ
                graphics.DrawRectangle(Pens.Black,
                    rotateRect.X, rotateRect.Y, rotateRect.Width, rotateRect.Height);
                Thread.Sleep(100);
                //���öԾ��δ�С�����б任
                graphics.ResetTransform();
                rotateRect.Inflate(-scale * 15, -scale * 15);
                scale++;
            }

        }

        private void FontRotate_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            FontFamily fontFamily = new FontFamily("����");
            Font myFont = new Font(fontFamily, 20, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush redBrush = new SolidBrush(Color.Red);

            //�����ı��������
            RectangleF layoutRect = new RectangleF(myFont.Height, myFont.Height,
                this.ClientSize.Width / 2, this.ClientSize.Height / 2);

            StringFormat format = new StringFormat();
            //�����ı������ʽ
            format.Alignment = StringAlignment.Near;
            format.LineAlignment = StringAlignment.Center;
            //���ı������������óɴ��ڵ�����
            graphics.TranslateTransform(layoutRect.Width, layoutRect.Height);

            //����תʱÿ��30������ı�
            for (int i = 0; i < 360; i += 30)
            {
                //��ת��ͼƽ��
                graphics.RotateTransform(i);
                graphics.DrawString(" ��ת����", myFont, redBrush,
                    layoutRect, format);
                //�ָ���������ת
                graphics.RotateTransform(-i);
            }

        }

        private void MirrorText_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            SolidBrush redBrush = new SolidBrush(Color.Red);

            //�������壬���ھ����ı����
            FontFamily fontFamily = new FontFamily("����_GB2312_GB2312");
            Font myFont = new Font(fontFamily,
                48, FontStyle.Regular, GraphicsUnit.Pixel);
            //����Ӣ�����壬������ʾ�ı����������
            FontFamily fontFamily2 = new FontFamily("Courier New");
            Font myFont2 = new Font(fontFamily2,
                16, FontStyle.Regular, GraphicsUnit.Pixel);

            //�����ı��������
            RectangleF layoutRect = new RectangleF(myFont.Height, myFont.Height,
                this.ClientSize.Width / 2, this.ClientSize.Height / 2);

            StringFormat format = new StringFormat();

            //�����ı����ʱ��ȷλ��
            //�о࣭���в��֡�(��Ƶ�λ)
            float ascent = fontFamily.GetLineSpacing(FontStyle.Regular) -
                fontFamily.GetCellDescent(FontStyle.Regular);
            //�о࣭���в��֡�(��Ƶ�λ)
            float ascent2 = fontFamily.GetLineSpacing(FontStyle.Regular) -
                fontFamily.GetCellAscent(FontStyle.Regular);

            //���ϡ��²��������Ƶ�λת�������ص�λ
            float ascentPixel = myFont.Size *
                ascent / (fontFamily.GetEmHeight(FontStyle.Regular));
            float ascentPixel2 = myFont.Size *
                ascent2 / (fontFamily.GetEmHeight(FontStyle.Regular));

            //��ͼƽ������
            graphics.TranslateTransform(0, this.ClientSize.Height / 4);
            //��������������ı�
            graphics.DrawString("�������", myFont, redBrush,
                new PointF(0, -myFont.Height + ascentPixel2), format);

            //��ͼƽ�����ƣ���ʾ��ǰ�ı��������
            graphics.TranslateTransform(200, 0);
            string msg = string.Empty;
            for (int i = 0; i < 3; i++)
            {
                msg = string.Format("Line {0}...........", i);
                graphics.DrawString(msg, myFont2, redBrush,
                    new PointF(0, myFont2.Height * i), format);
            }

            //�ָ��Ի�ͼƽ�������
            graphics.TranslateTransform(-200, 0);

            //��ͼƽ���ڴ�ֱ������
            graphics.ScaleTransform(1, -1);
            //��������ı�
            graphics.DrawString("�������", myFont, Brushes.Gray,
                new PointF(0, -ascentPixel), format);
            //��ͼƽ���ٴ����ƣ���ʾ��ǰ�ı��������
            graphics.TranslateTransform(200, 0);
            for (int i = 0; i < 3; i++)
            {
                msg = string.Format("Line {0}...........", i);
                graphics.DrawString(msg, myFont2, Brushes.Gray,
                    new PointF(0, myFont2.Height * i), format);
            }

            //�����ڻ�ͼƽ���Ͻ��е����б任����ʾˮƽ�����ı����
            graphics.ResetTransform();
            //��ͼƽ������
            graphics.TranslateTransform(this.ClientSize.Width / 2,
                this.ClientSize.Height / 2 + myFont.Height * 2);
            //��������������ı�
            graphics.DrawString("�������", myFont, redBrush,
                new PointF(0, 0), format);
            //��ͼƽ����ˮƽ������
            graphics.ScaleTransform(-1, 1);
            //���ˮƽ�����ı�
            graphics.DrawString("�������", myFont, Brushes.Gray,
                new PointF(0, 0), format);
        }


        private void Matrix_ListElements_Click_1(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush redBrush = new SolidBrush(Color.Red);
            FontFamily fontFamily = new FontFamily("����_GB2312_GB2312");
            Font myFont = new Font(fontFamily, 20,
                FontStyle.Regular, GraphicsUnit.Pixel);

            //����ƽ�Ʊ任	
            graphics.TranslateTransform(10, 10);
            graphics.TranslateTransform(20, 10);
            Matrix m = new Matrix(); ;
            m = graphics.Transform;
            //��ȡ�Ѿ�ʵʩ�ڻ�ͼƽ�������任
            float[] x = m.Elements;
            int index = 0;
            string msg = string.Empty;

            //��������ÿһ��Ԫ��
            foreach (float i in x)
            {
                msg = string.Format("��{0}������Ԫ��Ϊ{1:F2}", index, i);
                graphics.DrawString(msg, myFont, redBrush,
                    new PointF(0, myFont.Height * index));
                index++;
            }

        }

        private void MatrixPos_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 4);
            Pen pen2 = new Pen(Color.Gray);

            FontFamily fontFamily = new FontFamily("����");
            Font myFont = new Font(fontFamily,
                20, FontStyle.Regular, GraphicsUnit.Pixel);

            //��ȡ��ǰ���ڵĴ�С
            Rectangle rect = new Rectangle(0, 0,
                this.ClientSize.Width, this.ClientSize.Height);

            //���ö�����Բ�ľ���
            Rectangle r = new Rectangle(-40, -65, 80, 130);
            Matrix matrix = new Matrix();
            graphics.TranslateTransform(rect.Width / 2, rect.Height / 2);
            //ʹ��Ĭ�ϵ���ת˳��(MatrixOrder.Prepend)
            graphics.RotateTransform(20);
            //��ȡ�Ի�ͼƽ���Ѿ����е�����任
            matrix = graphics.Transform;
            //������Բ
            graphics.DrawEllipse(pen, r);

            //ʹ��MatrixOrder.Append��ת˳��
            graphics.ResetTransform();
            graphics.TranslateTransform(rect.Width / 2, rect.Height / 2);
            graphics.RotateTransform(20, MatrixOrder.Append);
            //ʹ�ú�ɫ���ʻ�����һ����Բ
            graphics.DrawEllipse(new Pen(Color.Red, 1), r);
            Matrix matrix2 = new Matrix();
            matrix2 = graphics.Transform;

            //��������任���Դ������ĵ�Ϊԭ�����������
            graphics.ResetTransform();
            graphics.DrawLine(pen2, 0, rect.Height / 2,
                rect.Width, rect.Height / 2);
            graphics.DrawLine(pen2, rect.Width / 2,
                0, rect.Width / 2, rect.Height);

            string msg = string.Empty;
            //��ȡ����Ԫ��ֵ
            float[] x = matrix.Elements;
            //�������Ԫ��ֵ
            int i = 0;
            foreach (float element in x)
            {
                msg += string.Format("{0,8:F2}", element);
                //���������
                if (i == 1 || i == 3 || i == 5)
                {
                    //��ֱ����������һ��
                    graphics.TranslateTransform(0, myFont.Height);
                    //graphics.DrawString (msg, myFont,Brushes.Black,
                    //	new PointF(0,0));
                    msg = string.Empty;
                }
                i++;
            }
        }

        private void Martrix_Invert_Click(object sender, System.EventArgs e)
        {
            Graphics myGraphics = this.CreateGraphics();
            myGraphics.Clear(Color.White);

            Pen myPen = new Pen(Color.Blue, 4);
            Matrix matrix = new Matrix(1.0f, 0.0f, 0.0f, 1.0f, 30.0f, 20.0f);
            //�������Ƿ���棿
            if (!matrix.IsInvertible)
            {
                MessageBox.Show("�þ���Ϊ��������Σ��޷���ʾ");
                return;
            }
            myGraphics.Transform = matrix;
            for (int i = 0; i < 200; i++)
            {
                //���������
                matrix.Invert();
                //�Ի�ͼƽ���������任
                myGraphics.Transform = matrix;
                myGraphics.DrawRectangle(myPen, 35, 25, 200, 100);
            }
        }

        private void Matrix_Multiply_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush brush = new SolidBrush(Color.Blue);
            FontFamily fontFamily = new FontFamily("Arial");
            Font myFont = new Font(fontFamily,
                16, FontStyle.Regular, GraphicsUnit.Pixel);
            //����ͼƬ
            Bitmap image = new Bitmap("jieba.bmp");

            //����
            Matrix matrix1 = new Matrix(0.80f, 0.0f, 0.0f, 0.8f, 0.0f, 0.0f);
            //λ��
            Matrix matrix2 = new Matrix(1.0f, 0.0f, 0.0f, 1.0f, 20.0f, 10.0f);
            //�����������·�תͼƬ��X����Y��Ե�
            Matrix matrix3 = new Matrix(0.0f, 1.0f, 1.0f, 0.0f, 0.0f, 0.0f);

            //��һ��׷�ӱ任
            matrix1.Multiply(matrix2, MatrixOrder.Append);
            //�ڶ���׷�ӱ任
            matrix1.Multiply(matrix3, MatrixOrder.Append);
            //���и��ϱ任
            graphics.Transform = matrix1;

            //����ͼƬ
            graphics.DrawImage(image, 0, 0);
            //��ȡ�Ѿ������ڻ�ͼƽ���ϵ�����任
            Matrix matrix = new Matrix();
            matrix = graphics.Transform;
            graphics.ResetTransform();
            //����λ���ϲ鿴�任������Ϣ
            graphics.TranslateTransform(image.Height, 0);

            //��ȡ����Ԫ��ֵ
            float[] x = matrix.Elements;
            //���ÿһ������Ԫ�ص�ֵ
            string msg = string.Empty;
            int i = 0;
            foreach (float element in x)
            {
                msg += string.Format("{0,6:F2}", element);
                //���������
                if (i == 1 || i == 3 || i == 5)
                {
                    //��ֱ����������һ��
                    graphics.TranslateTransform(0, myFont.Height);
                    graphics.DrawString(msg, myFont, Brushes.Black,
                        new PointF(0, 0));
                    msg = string.Empty;
                }
                i++;
            }
        }

        private void Matrix_TransformPoints_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            Pen pen1 = new Pen(Color.Blue, 2);
            Pen pen2 = new Pen(Color.Red, 1);

            //���幹�����ߵĵ�����
            Point[] points = new Point[]
		{
			new Point(50, 100), 
			new Point(100, 50),
			new Point(150, 125),
			new Point(200, 100),
			new Point(250, 125),
			};

            //��������(δʹ�ñ任ʱ)
            graphics.DrawCurve(pen1, points);
            //�������߶������Ϣ
            for (int i = 0; i < 5; i++)
            {
                graphics.FillEllipse(blueBrush,
                    points[i].X - 5, points[i].Y - 5, 10, 10);
            }

            //����һ������ֱ��������������Ϊ0.5�ľ���
            Matrix matrix = new Matrix(1.0f, 0.0f, 0.0f, 0.5f, 0.0f, 0.0f);
            //��points�����е�ÿһ����Ա���о�������
            matrix.TransformPoints(points);

            //��������(ʹ�ñ任��)	
            graphics.DrawCurve(pen2, points);

            //�ٴλ������߶������Ϣ
            for (int i = 0; i < 5; i++)
            {
                graphics.FillEllipse(redBrush,
                    points[i].X - 5, points[i].Y - 5, 10, 10);
            }
        }

        private void Matrix_TransformPoints2_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //��������ϵ��
            FontFamily fontFamily = new FontFamily("����_GB2312");

            SolidBrush redBrush = new SolidBrush(Color.Red);
            //�����ı��������
            graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            //����·������
            GraphicsPath path = new GraphicsPath();
            //��������׷���ı��������СΪ60
            path.AddString("������Ч", fontFamily, (int)FontStyle.Regular,
                60, new Point(0, 0), new StringFormat());

            //��ȡ·���ĵ���Ϣ
            PointF[] dataPoints = path.PathPoints;
            //��ȡ·���ĵ�������Ϣ
            byte[] pTypes = path.PathTypes;

            //����·�� 
            GraphicsPath path2 = (GraphicsPath)path.Clone();

            //���ı���ˮƽ��������С���ڴ�ֱ����������
            Matrix matrix = new Matrix(0.50f, 0.0f, 0.0f, 3.5f, 0.0f, 0.0f);

            //��points�����е�ÿһ����Ա���о�������
            matrix.TransformPoints(dataPoints);
            //���ݼ����ĵ����¹���·��
            GraphicsPath newpath = new GraphicsPath(dataPoints, pTypes);
            //���·��
            graphics.FillPath(redBrush, newpath);

            //�ڶ�����Ч
            Matrix matrix2 = new Matrix(0.6f, 0.5f, 0.20f, 1.5f, 160.0f, -40.0f);
            dataPoints = path2.PathPoints;
            //�����еĵ���м���
            matrix2.TransformPoints(dataPoints);
            //���ݼ����ĵ����¹���·��
            GraphicsPath newpath2 = new GraphicsPath(dataPoints, pTypes);
            graphics.FillPath(redBrush, newpath2);
        }

        private void Matrix_TransformVectors_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 7);
            pen.EndCap = LineCap.ArrowAnchor;
            SolidBrush brush = new SolidBrush(Color.Blue);

            // ����һ�����һ������
            PointF[] point = new PointF[] { new Point(100, 50) };
            PointF[] vector = new PointF[] { new Point(100, 50) };

            // ���Ƶ�point
            graphics.FillEllipse(brush, point[0].X - 5, point[0].Y - 5, 10, 10);
            //����(10,10)��vector��ʾ��λ����������
            graphics.DrawLine(pen, new Point(10, 10), vector[0]);

            // ����任����
            Matrix matrix = new Matrix(0.8f, 0.6f, -0.6f, 0.8f, 100.0f, 0.0f);
            //�Ե�point��λ����Ϣ���б任
            matrix.TransformPoints(point);
            //�Ե�vector��λ����Ϣ���ж�ά�����任
            matrix.TransformVectors(vector);

            // ���Ʊ任��ĵ�
            pen.Color = Color.Red;
            brush.Color = Color.Red;
            graphics.FillEllipse(brush, point[0].X - 5, point[0].Y - 5, 10, 10);
            //����(10,10)��任���vector��ʾ��λ����������
            graphics.DrawLine(pen, new Point(10, 10), vector[0]);
        }

        private void Matrix_RotateAt_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 4);
            Pen pen2 = new Pen(Color.Gray);

            //��ȡ��ǰ��������
            RectangleF rect = new RectangleF(0, 0,
                this.ClientSize.Width, this.ClientSize.Height); ;
            //���첢ƽ�ƾ��󵽴������ĵ�
            Matrix matrix = new Matrix();
            matrix.Translate(rect.Width / 2, rect.Height / 2);

            //����ͼƽ��������תһ��
            for (int i = 0; i < 360; i += 30)
            {
                //��ת��������ڴ������ĵ�
                matrix.RotateAt(i, new PointF(rect.Width / 2,
                    rect.Height / 2), MatrixOrder.Append);
                //����ת��ľ��������ڻ�ͼƽ��
                graphics.Transform = matrix;
                //������Բ
                graphics.DrawEllipse(pen, -80, -30, 160, 60);
                //���������ڻ�ͼƽ�������еı任
                graphics.ResetTransform();
            }

            //�Դ������ĵ�Ϊԭ�����������
            graphics.DrawLine(pen2, 0, rect.Height / 2,
                rect.Width, rect.Height / 2);
            graphics.DrawLine(pen2, rect.Width / 2, 0,
                rect.Width / 2, rect.Height);
        }

        private void Matrix_Shear_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //װ��ͼƬ
            Bitmap image = new Bitmap("jieba.bmp");
            //����ͼƬ����ʾ����
            Rectangle rect = new Rectangle(0, 0, 100, 150);
            //����Դͼ
            graphics.DrawImage(image, rect);

            Matrix matrix = new Matrix();
            //����ˮƽͶ������
            matrix.Shear(0.8f, 0.0f);
            //�Ի�ͼƽ��ʹ��Ͷ��任
            graphics.Transform = matrix;
            graphics.TranslateTransform(100, 0);
            //����Ͷ��任���ͼƬ
            graphics.DrawImage(image, rect);

            graphics.ResetTransform();
            Matrix matrix2 = new Matrix();
            //���ô�ֱͶ������
            matrix2.Shear(0.0f, 0.8f);
            //�Ի�ͼƽ��ʹ��Ͷ��任
            graphics.Transform = matrix2;
            graphics.TranslateTransform(200, 0);
            //����Ͷ��任���ͼƬ
            graphics.DrawImage(image, rect);
        }

        private void Matrix_TextoutShear_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush brush = new SolidBrush(Color.Blue);
            FontFamily fontFamily = new FontFamily("����_GB2312_GB2312");
            Font myFont = new Font(fontFamily, 20, FontStyle.Regular, GraphicsUnit.Pixel);

            Font myfont = new Font("Times New Roman", 100);
            Matrix mymat = new Matrix();
            //Ͷ��
            mymat.Shear(-1.4f, 0.0f);
            //����
            mymat.Scale(1, 0.5f);
            //ƽ��
            mymat.Translate(236, 170);
            //�Ի�ͼƽ��ʵʩ����任����
            graphics.Transform = mymat;

            SolidBrush mybrush = new SolidBrush(Color.Gray);
            SolidBrush redbrush = new SolidBrush(Color.Red);
            //������Ӱ
            graphics.DrawString("Hello", myfont, mybrush, new PointF(0, 50));
            graphics.ResetTransform();
            //����ǰ��
            graphics.DrawString("Hello", myfont, redbrush, new PointF(0, 50));
            string msg = string.Empty;
            //��ȡ����Ԫ��ֵ
            float[] x = mymat.Elements;
            //���ÿһ������Ԫ�ص�ֵ
            int i = 0;
            foreach (float elements in x)
            {
                msg += string.Format("{0,6:F2}", x[i]);
                //���������
                if (i == 1 || i == 3 || i == 5)
                {
                    graphics.DrawString(msg, myFont, Brushes.Black,
                        new PointF(0, 0));
                    //��ֱ����������һ��
                    graphics.TranslateTransform(0, myFont.Height);
                    msg = string.Empty;
                }
                i++;
            }
        }

        private void Matrix_ChangeFontHeight_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //��������ϵ��
            FontFamily fontFamily = new FontFamily("����_GB2312");
            //����·������
            GraphicsPath path = new GraphicsPath();
            SolidBrush redBrush = new SolidBrush(Color.Red);

            //�����ı��������
            graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            //��������׷���ı��������СΪ80
            path.AddString("��С����", fontFamily, (int)FontStyle.Regular,
                80, new Point(0, 0), new StringFormat());
            //��ȡ·����ռ�ľ�������
            RectangleF bound = path.GetBounds();
            //��ȡ·����������ĵ�
            float halfH = bound.Height / 2;
            float halfW = bound.Width / 2;

            //��·��ʵʩ�任������·����������ĵ�
            Matrix pathMartrix = new Matrix(1, 0, 0, 1, -halfW, -halfH);
            path.Transform(pathMartrix);

            //��ȡ·���ĵ���Ϣ
            PointF[] dataPoints = path.PathPoints;
            //��ȡ·���ĵ�������Ϣ
            byte[] pTypes = path.PathTypes;

            //���ζ�·���Ķ�����Yֵ��������
            for (int i = 0; i < path.PointCount; i++)
            {
                //���ݸõ��·�����ľ���ռ����·�����ȵı�������Yֵ
                dataPoints[i].Y *= 2 * (bound.Width - Math.Abs(dataPoints[i].X)) / bound.Width;
            }

            //���ݸ��ĺ��·����������¹���·��
            GraphicsPath newpath = new GraphicsPath(dataPoints, pTypes);
            //����ͼƽ���ԭ���Ƶ���������
            graphics.TranslateTransform(this.ClientSize.Width / 2, this.ClientSize.Height / 2 - 40);
            //���·��
            graphics.FillPath(redBrush, newpath);
        }

        private void ColorMatrix��Start_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //����ͼƬ
            Bitmap image = new Bitmap("ColorInput.bmp");
            int width = image.Width;
            int height = image.Height;
            ImageAttributes imageAttributes = new ImageAttributes();

            //����ɫ�ʱ任����
            float[][] colorMatrixElements =
		{
			new float[]{2.0f, 0.0f, 0.0f, 0.0f, 0.0f},
			new float[] { 0.0f, 1.0f, 0.0f, 0.0f, 0.0f},
			new float[] { 0.0f, 0.0f, 1.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 1.0f, 0.0f},
			new float[]{1.0f, 0.0f, 0.0f, 0.0f, 1.0f}
		};
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);

            //����ɫ�ʱ任����
            imageAttributes.SetColorMatrix(
                colorMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);

            //����Դͼ
            graphics.DrawImage(image, 0, 0);
            //ʹ��ɫ�ʱ任�������ͼƬ
            graphics.TranslateTransform(width + 10, 0);
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, width, height),
                0, 0,
                width, height, GraphicsUnit.Pixel,
                imageAttributes);
        }

        private void TranslateColor_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //����ͼƬ
            Bitmap image = new Bitmap("ColorBar.bmp");
            ImageAttributes imageAttributes = new ImageAttributes();
            int width = image.Width;
            int height = image.Height;

            //����ɫ�ʱ任����
            float[][] colorMatrixElements =
	{
		new float[]{1.0f,  0.0f, 0.0f, 0.0f, 0.0f},
		new float[]{0.0f,  1.0f, 0.0f, 0.0f, 0.0f},
		new float[]{0.0f,  0.0f, 1.0f, 0.0f, 0.0f},
		new float[]{0.0f,  0.0f, 0.0f, 1.0f, 0.0f},
		new float[]{0.75f, 0.0f, 0.0f, 0.0f, 1.0f}
	};
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);

            //����ɫ�ʱ任����
            imageAttributes.SetColorMatrix(colorMatrix,
                ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            //����Դͼ
            graphics.DrawImage(image, 0, 0);
            //ʹ��ɫ�ʱ任�������ͼƬ
            graphics.TranslateTransform(width + 10, 0);
            graphics.DrawImage(image, new Rectangle(0, 0, width, height),
                0, 0, width, height, GraphicsUnit.Pixel, imageAttributes);
        }

        private void ScaleColor_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //����ͼƬ
            Bitmap image = new Bitmap("ColorBar.bmp");
            ImageAttributes imageAttributes = new ImageAttributes();
            int width = image.Width;
            int height = image.Height;

            //����ɫ�ʱ任����1
            float[][] colorMatrixElements =
	{
		new float[]{0.5f, 0.0f, 0.0f, 0.0f, 0.0f},
		new float[]{0.0f, 0.5f, 0.0f, 0.0f, 0.0f},
		new float[]{0.0f, 0.0f, 0.50f, 0.0f, 0.0f},
		new float[]{0.0f, 0.0f, 0.0f, 1.0f, 0.0f},
		new float[]{0.0f, 0.0f, 0.0f, 0.0f, 1.0f}
	};
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            //����ɫ�ʱ任����2
            float[][] colorMatrixElements2 =
	{
		new float[]{0.5f, 0.0f, 0.0f, 0.0f, 0.0f},
		new float[]{0.0f, 0.5f, 0.0f, 0.0f, 0.0f},
		new float[]{0.0f, 0.0f, 500.50f, 0.0f, 0.0f},
		new float[]{0.0f, 0.0f, 0.0f, 1.0f, 0.0f},
		new float[]{0.0f, 0.0f, 0.0f, 0.0f, 1.0f}
	};
            ColorMatrix colorMatrix2 = new ColorMatrix(colorMatrixElements2);

            //����ɫ�ʱ任����1
            imageAttributes.SetColorMatrix(
                colorMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);

            //����Դͼ
            graphics.DrawImage(image, 0, 0);
            //ʹ��ɫ�ʱ任�������ͼƬ
            graphics.TranslateTransform(width + 10, 0);
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, width, height),
                0, 0,
                width, height, GraphicsUnit.Pixel,
                imageAttributes);

            //����Ѿ���ȡ��ɫ�ʱ任
            imageAttributes.ClearColorMatrix(ColorAdjustType.Bitmap);
            //���¼�����һ�任����Matrix2
            imageAttributes.SetColorMatrix(
                colorMatrix2,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);

            //��ʾʹ��Matrix2��ɫ�ʵ������
            graphics.TranslateTransform(width + 10, 0);
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, width, height),
                0, 0,
                width, height, GraphicsUnit.Pixel,
                imageAttributes);
        }

        private void RotateColor_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //����ͼƬ
            Bitmap image = new Bitmap("Colorinput.bmp");
            int width = image.Width;
            int height = image.Height;
            float degrees = 90;
            //�ӽǶȵ�����
            double r = degrees * Math.PI / 180.0f;
            ImageAttributes imageAttributes = new ImageAttributes();
            //����Դͼ
            graphics.DrawImage(image, 0, 0);

            //��ɫ������ɫ��ת
            float[][] colorMatrixElements =
		{
			new float[]{(float)Math.Cos(r),  (float)Math.Sin(r), 0.0f, 0.0f, 0.0f},
			new float[]{-(float)Math.Sin(r), (float)Math.Cos(r), 0.0f, 0.0f, 0.0f},
			new float[]{0.0f,    0.0f,   1.0f, 0.0f, 0.0f},
			new float[]{0.0f,    0.0f,   0.0f, 1.0f, 0.0f},
			new float[]{0.0f,    0.0f,   0.0f, 0.0f, 1.0f}
		};
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);

            //ʹ��ɫ�ʱ任�������ͼƬ(R->B)
            graphics.TranslateTransform(width + 10, 0);
            //����R->Bɫ�ʱ任����
            imageAttributes.SetColorMatrix(
                colorMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);
            graphics.DrawImage(
                image,
                new Rectangle(0, 10, width, height),
                0, 0, width, height,
                GraphicsUnit.Pixel,
                imageAttributes);

            //����Ѿ���ȡ��ɫ�ʱ任
            imageAttributes.ClearColorMatrix(ColorAdjustType.Bitmap);

            //���¼�����һ�任����Matrix2
            //��ɫ���ź�ɫ��ת
            float[][] colorMatrixElements2 =
	{
		new float[]{1,  0, 0.0f, 0.0f, 0.0f},
		new float[]{0, (float)Math.Cos(r), (float)Math.Sin(r), 0.0f, 0.0f},
		new float[]{0.0f, -(float)Math.Sin(r), (float)Math.Cos(r), 0.0f, 0.0f},
		new float[]{0.0f,    0.0f,   0.0f, 1.0f, 0.0f},
		new float[]{0.0f,    0.0f,   0.0f, 0.0f, 1.0f}
	};
            ColorMatrix colorMatrix2 = new ColorMatrix(colorMatrixElements2);

            imageAttributes.SetColorMatrix(
                colorMatrix2,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);

            //�ڵڶ������
            graphics.ResetTransform();
            graphics.TranslateTransform(0, height + 10);
            graphics.DrawImage(image,
                new Rectangle(0, 0, width, height),
                0, 0, width, height, GraphicsUnit.Pixel,
                imageAttributes);

            //����Ѿ���ȡ��ɫ�ʱ任
            imageAttributes.ClearColorMatrix(ColorAdjustType.Bitmap);
            //��ɫ���ź�ɫ��
            float[][] colorMatrixElements3 =
	{

		new float[]{(float)Math.Cos(r),  0, -(float)Math.Sin(r), 0.0f, 0.0f},
		new float[]{0, 1, 0.0f, 0.0f, 0.0f},
		new float[]{(float)Math.Sin(r), 0, (float)Math.Cos(r), 0.0f, 0.0f},
		new float[]{0.0f,    0.0f,   0.0f, 1.0f, 0.0f},
		new float[]{0.0f,    0.0f,   0.0f, 0.0f, 1.0f}
	};
            ColorMatrix colorMatrix3 = new ColorMatrix(colorMatrixElements3);

            //���¼�����һ�任����Matrix3
            imageAttributes.SetColorMatrix(
                colorMatrix3,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);
            graphics.TranslateTransform(width + 10, 0);
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, width, height),
                0, 0,
                width, height, GraphicsUnit.Pixel,
                imageAttributes);
        }

        private void ColorShear_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //����ͼƬ
            Bitmap image = new Bitmap("Colorinput.bmp");
            ImageAttributes imageAttributes = new ImageAttributes();
            int width = image.Width;
            int height = image.Height;

            //����ɫ�ʱ任����
            float[][] colorMatrixElements =
	{
		new float[]{1.0f, 0.0f, 0.0f, 0.0f, 0.0f},
		new float[]{0.0f, 1.0f, 0.0f, 0.0f, 0.0f},
		new float[]{0.5f, 0.0f, 1.0f, 0.0f, 0.0f},
		new float[]{0.0f, 0.0f, 0.0f, 1.0f, 0.0f},
		new float[]{ 0.0f, 0.0f, 0.0f, 0.0f, 1.0f}
	};

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            //����ɫ�ʱ任����
            imageAttributes.SetColorMatrix(
                colorMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);

            //����Դͼ
            graphics.DrawImage(image, 0, 0);
            //ʹ��ɫ�ʱ任�������ͼƬ
            graphics.TranslateTransform(width + 10, 0);
            graphics.DrawImage(image, new Rectangle(0, 0, width, height),
                0, 0, width, height, GraphicsUnit.Pixel, imageAttributes);

        }

        private void ColorRemap_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //������ɫ������ͼƬ
            Bitmap image = new Bitmap("Nemo_Blue.bmp");
            ImageAttributes imageAttributes = new ImageAttributes();

            int width = image.Width;
            int height = image.Height;
            //����ɫ�滻�ɰ�ɫ,�Դﵽ�ٳ���Ч��
            ColorMap colorMap = new ColorMap();
            colorMap.OldColor = Color.FromArgb(255, 0, 0, 255);
            colorMap.NewColor = Color.FromArgb(255, 255, 255, 255);
            //����ɫ��ת����
            ColorMap[] remapTable = { colorMap };

            //����ͼƬ��ɫ����Ϣ
            imageAttributes.SetRemapTable(remapTable, ColorAdjustType.Bitmap);
            //����ԭʼͼ��
            graphics.DrawImage(image, 0, 0, width, height);
            //�����Ѿ��ٳ�����ɫ����ͼ��
            graphics.DrawImage(image,
                new Rectangle(width + 10, 0, width, height),  //Ŀ������
                0, 0,        // Դͼ���Ͻ�����
                width,       // Դͼ��
                height,      // Դͼ��
                GraphicsUnit.Pixel,
                //ͼƬ��ɫ����Ϣ
                imageAttributes);
        }

        private void SetRGBOutputChannel_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //����ͼƬ
            Bitmap image = new Bitmap("jieba.bmp");
            //����Դͼ
            graphics.DrawImage(image, 0, 0);

            int width = image.Width;
            int height = image.Height;
            ImageAttributes imageAttributes = new ImageAttributes();

            //���ú�ɫͨ��
            float[][] colorMatrixElements =
		{
			new float[]{1.0f, 0.0f, 0.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 1.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 1.0f}
		};
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);

            //����ɫ�ʱ任����
            imageAttributes.SetColorMatrix(
                colorMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);
            //ʹ��ɫ�ʱ任�������ͼƬ
            graphics.TranslateTransform(width + 10, 0);
            graphics.DrawImage(image, new Rectangle(0, 0, width, height),
                0, 0, width, height, GraphicsUnit.Pixel, imageAttributes);

            //����Ѿ���ȡ��ɫ�ʱ任
            imageAttributes.ClearColorMatrix(ColorAdjustType.Bitmap);
            //������ɫͨ��
            float[][] colorMatrixElements2 =
		{
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 0.0f},
			new float[]{0.0f, 1.0f, 0.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 1.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 1.0f}
		};
            ColorMatrix colorMatrix2 = new ColorMatrix(colorMatrixElements2);

            //����ɫ�ʱ任����
            imageAttributes.SetColorMatrix(
                colorMatrix2,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);
            //ʹ��ɫ�ʱ任�������ͼƬ
            graphics.ResetTransform();
            graphics.TranslateTransform(0, height + 10);
            graphics.DrawImage(image, new Rectangle(0, 0, width, height),
                0, 0, width, height, GraphicsUnit.Pixel, imageAttributes);

            //����Ѿ���ȡ��ɫ�ʱ任
            imageAttributes.ClearColorMatrix(ColorAdjustType.Bitmap);

            //������ɫͨ��
            float[][] colorMatrixElements3 =
		{
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 1.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 1.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 1.0f}
		};
            ColorMatrix colorMatrix3 = new ColorMatrix(colorMatrixElements3);

            //����ɫ�ʱ任����
            imageAttributes.SetColorMatrix(
                colorMatrix3,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);

            //ʹ��ɫ�ʱ任�������ͼƬ
            graphics.TranslateTransform(width + 10, 0);
            graphics.DrawImage(image, new Rectangle(0, 0, width, height),
                0, 0, width, height, GraphicsUnit.Pixel, imageAttributes);
        }

        private void Metafile_Click(object sender, System.EventArgs e)
        {
            Graphics metagraph = this.CreateGraphics();

            //�½�һ��ͼԪ�ļ�
            IntPtr hdc = metagraph.GetHdc();
            Metafile metaFile1 = new Metafile("ͼԪ�ļ�ʾ��.emf", hdc);
            //ʹ��Metafile����ĵ�ַ��Ϊ��ͼƽ��
            Graphics graphics = Graphics.FromImage(metaFile1);

            //����һ���ɺ쵽���Ľ���ɫ��ˢ
            LinearGradientBrush RtoBBrush = new LinearGradientBrush(
                new Point(0, 10),
                new Point(200, 10),
                Color.Red,
                Color.Blue);

            //����һ���������ƵĽ���ɫ��ˢ
            LinearGradientBrush BtoYBrush = new LinearGradientBrush(
                new Point(0, 10),
                new Point(200, 10),
                Color.Blue,
                Color.Yellow);
            Pen bluePen = new Pen(Color.Blue);
            // ���µĲ���������Ļ�ϻ���һ����ͼ��
            Rectangle ellipseRect = new Rectangle(0, 0, 200, 200);
            Rectangle left = new Rectangle(0, 50, 100, 100);
            graphics.DrawArc(bluePen, left, 180.0f, 180.0f);
            Rectangle right = new Rectangle(100, 50, 100, 100);
            graphics.FillPie(RtoBBrush, ellipseRect, 0.0f, 180.0f);
            graphics.FillPie(BtoYBrush, ellipseRect, 180.0f, 180.0f);
            graphics.FillPie(RtoBBrush, left, 180.0f, 180.0f);
            graphics.FillPie(BtoYBrush, right, 0.0f, 180.0f);

            //�ı���� 
            SolidBrush solidBrush = new SolidBrush(Color.Black);
            FontFamily fontFamily = new FontFamily("����_GB2312");
            Font font = new Font(fontFamily, 27,
                FontStyle.Regular, GraphicsUnit.Pixel);
            graphics.DrawString("ͼԪ�ļ�ʾ��", font, solidBrush,
                new PointF(20.0f, 80.0f));
            //���ˣ�GDI+���е�ֻ����Ӳ���д��ͼƬ��Ϣ�Ĳ���

            //�ͷ�������Դ��
            graphics.Dispose();
            metaFile1.Dispose();
            metagraph.ReleaseHdc(hdc);
            metagraph.Dispose();

            //������Ļ�ͼ��Ϣ���лط�
            Graphics playbackGraphics = this.CreateGraphics();
            playbackGraphics.Clear(Color.White);
            //�򿪲���ʾͼԪ�ļ�
            Metafile metaFile2 = new Metafile("ͼԪ�ļ�ʾ��.emf");
            playbackGraphics.DrawImage(metaFile2, new Point(0, 0));
            //�ر��Ѿ��򿪵�ͼԪ�ļ�
            metaFile2.Dispose();
        }

        private void CroppingAndScaling_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //����ͼƬ
            Bitmap image = new Bitmap("nemo.bmp");
            int width = image.Width;
            int height = image.Height;

            // Ŀ����ʾ������Դͼ��С�Ļ����ϷŴ�1.4��
            RectangleF destinationRect = new RectangleF(
                width + 10, 0.0f, 1.4f * width, 1.4f * height);
            //����Դͼ
            graphics.DrawImage(image, 0, 0);

            //��Ŀ�����������λͼ
            graphics.DrawImage(
                image,
                destinationRect,
                new RectangleF(0, 0,    // ԭͼ���Ͻ�
                0.65f * width,      // ����ʾԭͼ��ȵ�65%����
                0.65f * height),      // ����ʾԭͼ�߶ȵ�65%����
                GraphicsUnit.Pixel);
        }

        private void UsingInterpolationMode_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //װ��ͼƬ
            Bitmap image = new Bitmap("eagle.bmp");
            int width = image.Width;
            int height = image.Height;

            //����Դͼ
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, width, height),  //Ŀ������ 
                0, 0,        //Դͼ���Ͻ�����
                width,       //Դͼ���
                height,      //Դͼ��
                GraphicsUnit.Pixel);

            //��ͼƽ������
            graphics.TranslateTransform(width + 10, 0);
            //���ٽ���ֵ��(������)
            graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            graphics.DrawImage(
                image,
                new RectangleF(0.0f, 0.0f, 0.6f * width, 0.6f * height),  //Ŀ������
                new RectangleF(0, 0,        //Դͼ���Ͻ�����
                width,       //Դͼ���
                height),      //Դͼ��
                GraphicsUnit.Pixel);

            //��ͼƽ������
            graphics.TranslateTransform(0.6f * width + 10, 0);
            // ������˫���Բ�ֵ��
            graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
            graphics.DrawImage(
                image,
                new RectangleF(0, 0, 0.6f * width, 0.6f * height),  //Ŀ������
                new Rectangle(0, 0,        //Դͼ���Ͻ�����
                width,       //Դͼ���
                height),      //Դͼ��
                GraphicsUnit.Pixel);

            //��ͼƽ������
            graphics.TranslateTransform(0.6f * width + 10, 0f);
            // ������˫���β�ֵ��
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.DrawImage(
                image,
                new RectangleF(0, 0, 0.6f * width, 0.6f * height),  //Ŀ������
                new Rectangle(0, 0,        //Դͼ���Ͻ�����
                width,       //Դͼ���
                height),      //Դͼ��
                GraphicsUnit.Pixel);
        }

        private void RotateFlip_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            //����ͼƬ	
            Bitmap photo = new Bitmap("nemo2.bmp");

            //�õ�ͼƬ�ߴ�
            int iWidth = photo.Width;
            int iHeight = photo.Height;
            //����ԭʼͼƬ
            graphics.DrawImage(photo, 10 + photo.Width + 2,
                10, photo.Width, photo.Height);
            //ˮƽ��תͼƬ 
            photo.RotateFlip(RotateFlipType.RotateNoneFlipX);
            //��ת���ͼƬ
            graphics.DrawImage(photo, 10, 10, photo.Width, photo.Height);
        }

        private void ImageSkewing_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //����ͼ�ε�Ŀ����ʾ����
            Point[] destination = new Point[]
		{
			new Point(200, 20),   //ԭʼͼ�����Ͻ�ӳ��������
			new Point(110, 100), //ԭʼͼ�����Ͻ�ӳ��������
			new Point(250, 30)  //ԭʼͼ�����½�ӳ��������
		};
            Bitmap image = new Bitmap("Stripes.bmp");
            // ����ԭʼͼ��
            graphics.DrawImage(image, 0, 0);

            // ���ƻ���ƽ���ı���ӳ����ͼ��
            graphics.TranslateTransform(image.Width, 0);
            graphics.DrawImage(image, destination);

        }


        private void Cubeimage_Click(object sender, System.EventArgs e)
        {
            int WIDTH = 200;
            int LEFT = 200;
            int TOP = 200;

            Graphics graphics = this.CreateGraphics();
            //ʹ�ú�ɫ������ɫ����
            graphics.Clear(Color.Black);

            //���ò�ֵģʽ��������˫���β�ֵ��
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //�ֱ�װ�������������������ͼƬ
            Bitmap face = new Bitmap("rose.bmp");
            Bitmap top = new Bitmap("flower.bmp");
            Bitmap right = new Bitmap("yujinxiang.bmp");

            //���¶������������������ͼƬ����
            Point[] destinationFace = new Point[]
		{
			new Point(LEFT,TOP), 
			new Point(LEFT+WIDTH, TOP),
			new Point(LEFT, TOP+WIDTH)
		};
            //��������ͼ��
            graphics.DrawImage(face, destinationFace);

            //���¶������������ڶ�����ͼƬ����	
            PointF[] destinationTop = new PointF[]
		{
			new PointF(LEFT+WIDTH/2, TOP-WIDTH/2),
			new PointF(LEFT+WIDTH/2+WIDTH, TOP-WIDTH/2), 
			new PointF(LEFT, TOP)
		};
            //����������ͼ��		
            graphics.DrawImage(top, destinationTop);

            //���¶��������������Ҳ��ͼƬ����				
            Point[] destinationRight = new Point[]
		{
			new Point(LEFT+WIDTH, TOP),
			new Point(LEFT+WIDTH/2+WIDTH, TOP-WIDTH/2), 
			new Point(LEFT+WIDTH,TOP+WIDTH)
		};
            //�����Ҳ���ͼ��						
            graphics.DrawImage(right, destinationRight);
        }

        public bool ThumbnailCallback()
        {
            return false;
        }

        private void ThumbnailImage_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //���ò�ֵģʽ��������˫���β�ֵ��
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //�������鿴����ͼ��ͼƬ
            Bitmap image = new Bitmap("flower.bmp");
            //��ȡ��ǰ���ڴ�С
            Rectangle client = new Rectangle(0, 0,
                this.ClientSize.Width, this.ClientSize.Height);

            float width = image.Width;
            float height = image.Height;

            //��ȡָ����С������ͼ
            Image.GetThumbnailImageAbort myCallback =
                new Image.GetThumbnailImageAbort(ThumbnailCallback);
            Image pThumbnail = image.GetThumbnailImage(40, 40, myCallback, IntPtr.Zero);

            //������ͼ��Ϊ��ˢ
            TextureBrush picBrush = new TextureBrush(pThumbnail);
            //��䴰��
            graphics.FillEllipse(picBrush, client);
        }

        private void Clone_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Bitmap image = new Bitmap("head.bmp");
            int Height = image.Height;
            int Width = image.Width;

            //���彫ͼƬ�зֳ��ĸ����ֵ�����
            RectangleF[] block = new RectangleF[4];
            block[0] = new Rectangle(0, 0, Width / 2, Height / 2);
            block[1] = new Rectangle(Width / 2, 0, Width / 2, Height / 2);
            block[2] = new Rectangle(0, Height / 2, Width / 2, Height / 2);
            block[3] = new Rectangle(Width / 2, Height / 2, Width / 2, Height / 2);

            //�ֱ��¡ͼƬ���ĸ�����	
            Bitmap[] s = new Bitmap[4];
            s[0] = image.Clone(block[0], PixelFormat.DontCare);
            s[1] = image.Clone(block[1], PixelFormat.DontCare);
            s[2] = image.Clone(block[2], PixelFormat.DontCare);
            s[3] = image.Clone(block[3], PixelFormat.DontCare);
            //����ͼƬ���ĸ����֣������ֻ���ʱ����Ϊ1��
            graphics.DrawImage(s[0], 0, 0);

            //��ʱ���Դﵽ�ֿ���ʾ��Ч��
            Thread.Sleep(1000);
            graphics.DrawImage(s[1], Width / 2, 0);
            Thread.Sleep(1000);
            graphics.DrawImage(s[3], Width / 2, Height / 2);
            Thread.Sleep(1000);
            graphics.DrawImage(s[2], 0, Height / 2);
        }

        private void Picturescale_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //װ��ͼƬ
            Bitmap image = new Bitmap("photo.bmp");

            //����ͼƬ����ʾ����
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
            graphics.DrawImage(image, rect);

            //�ֲ���С�������СΪ80*80
            graphics.TranslateTransform(image.Width + 10, 0);
            Rectangle smallrect = new Rectangle(0, 0, 80, 80);
            //�ֲ���С
            graphics.DrawImage(image, smallrect, 80, 10, 106, 112, GraphicsUnit.Pixel);

            graphics.TranslateTransform(0, 100);
            //�ֲ��Ŵ�������СΪ80*80
            Rectangle largerect = new Rectangle(0, 0, 80, 80);
            //���ƷŴ��ľֲ�ͼ��
            graphics.DrawImage(image, largerect, 56, 101, 35, 40, GraphicsUnit.Pixel);
        }

        private void ImageAttributesSetNoOp_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Bitmap image = new Bitmap("ColorTable.bmp");
            int width = image.Width;
            //���Ʊ�׼ͼƬ  
            graphics.DrawImage(image, 0, 0);

            graphics.TranslateTransform(image.Width + 10, 0);
            ImageAttributes imAtt = new ImageAttributes();

            //����һ����ɫת������ɫ�ı任����   


            float[][] colorMatrixElements =
		{     
			new float[]{0.0f, 1.0f, 0.0f, 0.0f, 0.0f},
			new float[]{0.0f, 1.0f, 0.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 1.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 1.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 1.0f}
		};
            ColorMatrix brushMatrix = new ColorMatrix(colorMatrixElements);
            //����ɫ��У��
            imAtt.SetColorMatrix(
                brushMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);

            //ʹ��ɫ��У������ͼƬ
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, image.Width, image.Height),  //Ŀ��λ��
                0, 0, image.Width, image.Height,        //Դλ��
                GraphicsUnit.Pixel,
                imAtt);

            //��ʱ�ر�ɫ��У��
            imAtt.SetNoOp(ColorAdjustType.Bitmap);

            //��ʹ��ɫ��У������ͼƬ��ɫ->��ɫ
            graphics.TranslateTransform(width + 10, 0);
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, image.Width, image.Height),  //Ŀ��λ��
                0, 0, image.Width, image.Height,          //Դλ��
                GraphicsUnit.Pixel,
                imAtt);

            //������ɫ��У���Ĺر�
            imAtt.ClearNoOp(ColorAdjustType.Bitmap);

            //ʹ��ɫ��У������ͼƬ����ɫ->��ɫ
            graphics.TranslateTransform(width + 10, 0);
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, image.Width, image.Height),  //Ŀ��λ��
                0, 0, image.Width, image.Height,          //Դλ��
                GraphicsUnit.Pixel,
                imAtt);
        }


        private void CreateMetaFile()
        {
            Graphics metagraph = this.CreateGraphics();

            //�½�һ��ͼԪ�ļ�
            IntPtr hdc = metagraph.GetHdc();
            Metafile metaFile1 = new Metafile("ddd.emf", hdc);
            //ʹ��Metafile����ĵ�ַ��Ϊ��ͼƽ��
            Graphics graphics = Graphics.FromImage(metaFile1);
            graphics.ScaleTransform(0.8f, 0.8f);

            //����ˮƽ�������������Բ�����
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            //��ɫ��Բ
            graphics.DrawEllipse(new Pen(Color.Red, 10),
                new Rectangle(0, 0, 75, 95));
            graphics.FillEllipse(Brushes.Red,
                new Rectangle(0, 0, 75, 95));

            //��ɫ��Բ
            graphics.DrawEllipse(new Pen(Color.Green, 10),
                new Rectangle(40, 0, 75, 95));
            graphics.FillEllipse(Brushes.Green,
                new Rectangle(40, 0, 75, 95));

            //��ɫ��Բ
            graphics.DrawEllipse(new Pen(Color.Blue, 10),
                new Rectangle(80, 0, 75, 95));
            graphics.FillEllipse(Brushes.Blue, new Rectangle(80, 0, 75, 95));

            // ׷������ɫ�ʵ��ı�
            FontFamily fontFamily = new FontFamily("Arial");
            Font font = new Font(fontFamily,
                24, FontStyle.Regular, GraphicsUnit.Pixel);
            graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

            //��ɫ����
            graphics.DrawString("GDI+", font, Brushes.Red,
                new PointF(-80.0f, 0.0f));
            //��ɫ����
            graphics.DrawString("GDI+", font, Brushes.Green,
                new PointF(-80.0f, font.Height));
            //��ɫ����
            graphics.DrawString("GDI+", font, Brushes.Blue,
                new PointF(-80.0f, font.Height * 2));
            //�ͷ�������Դ��
            graphics.Dispose();
            metaFile1.Dispose();
            metagraph.ReleaseHdc(hdc);
            metagraph.Dispose();
        }

        private void SetColorMatrices_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //����ͼԪ�ļ�	
            Metafile image = new Metafile("ddd.emf");
            GraphicsUnit unit = GraphicsUnit.Pixel;
            //��ȡͼƬ����
            RectangleF rect = image.GetBounds(ref unit);

            //��ʹ���κ�ɫ��У�����ͼƬ
            graphics.DrawImage(image, 0.0f, 0.0f, rect.Width, rect.Height);
            ImageAttributes imAtt = new ImageAttributes();

            //����һ��ʹ��ɫ��������1.5�ľ���
            float[][] colorMatrixElements =
		{ 
			new float[]{1.5f,  0.0f,  0.0f,  0.0f,  0.0f},
			new float[]{0.0f,  1.0f,  0.0f,  0.0f,  0.0f},
			new float[]{0.0f,  0.0f,  1.0f,  0.0f,  0.0f},
			new float[]{0.0f,  0.0f,  0.0f,  1.0f,  0.0f},
			new float[]{0.0f,  0.0f,  0.0f,  0.0f,  1.0f}
		};
            ColorMatrix defaultColorMatrix = new ColorMatrix(colorMatrixElements);

            //����һ��ʹ��ɫ��������1.5�ľ���
            float[][] colorMatrixElements2 =
		{  
			new float[]{1.0f,  0.0f,  0.0f,  0.0f,  0.0f},
			new float[]{0.0f,  1.5f,  0.0f,  0.0f,  0.0f},
			new float[]{0.0f,  0.0f,  1.0f,  0.0f,  0.0f},
			new float[]{0.0f,  0.0f,  0.0f,  1.0f,  0.0f},
			new float[]{0.0f,  0.0f,  0.0f,  0.0f,  1.0f}
		};
            ColorMatrix defaultGrayMatrix = new ColorMatrix(colorMatrixElements2);

            //���ʵĲ�ɫɫ����Ϣ��У��������ɫ��������1.5�ľ���
            float[][] colorMatrixElements3 = 
		{  
			new float[]{1.0f,  0.0f,  0.0f,  0.0f,  0.0f},
			new float[]{0.0f,  1.0f,  0.0f,  0.0f,  0.0f},
			new float[]{0.0f,  0.0f,  1.5f,  0.0f,  0.0f},
			new float[]{0.0f,  0.0f,  0.0f,  1.0f,  0.0f},
			new float[]{0.0f,  0.0f,  0.0f,  0.0f,  1.0f}
		};
            ColorMatrix penColorMatrix = new ColorMatrix(colorMatrixElements3);

            //���ʵĻҶ�ɫ�������з�������1.5�ľ���
            float[][] colorMatrixElements4 =
	{      
		new float[]{1.5f,  0.0f,  0.0f,  0.0f,  0.0f},
		new float[]{0.0f,  1.5f,  0.0f,  0.0f,  0.0f},
		new float[]{0.0f,  0.0f,  1.5f,  0.0f,  0.0f},
		new float[]{0.0f,  0.0f,  0.0f,  1.0f,  0.0f},
		new float[]{0.0f,  0.0f,  0.0f,  0.0f,  1.0f}
	};

            ColorMatrix penGrayMatrix = new ColorMatrix(colorMatrixElements4);

            // ����Ĭ�ϵĲ�ɫ���Ҷ�У������.
            //ColorAdjustType.Default:�޸����е�ɫ����Ϣ
            imAtt.SetColorMatrices(
                defaultColorMatrix,
                defaultGrayMatrix,
                ColorMatrixFlag.AltGrays,
                ColorAdjustType.Default);
            //ʹ��У���������ͼԪ�ļ���У�����е�ɫ��
            graphics.TranslateTransform(image.Width + 10, 0);
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, (int)rect.Width, (int)rect.Height),
                rect.X, rect.Y,
                rect.Width,
                rect.Height,
                GraphicsUnit.Pixel,
                imAtt);

            //���û��ʵĲ�ɫ���Ҷ�ɫ��У������
            //ColorAdjustType.Pen����������ɫ��
            imAtt.SetColorMatrices(
                penColorMatrix,
                penGrayMatrix,
                ColorMatrixFlag.AltGrays,
                ColorAdjustType.Pen);
            //�ڵڶ��л���
            graphics.ResetTransform();
            graphics.TranslateTransform(0, image.Height);
            //ʹ��������Ļ��ʻ���ͼƬ 
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, (int)rect.Width, (int)rect.Height),
                rect.X, rect.Y,
                rect.Width,
                rect.Height,
                GraphicsUnit.Pixel,
                imAtt);

            graphics.TranslateTransform(image.Width + 10, 0);
            //����ڻ����ϵ����б任
            imAtt.ClearColorMatrix(ColorAdjustType.Pen);
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, (int)rect.Width, (int)rect.Height),
                rect.X, rect.Y,
                rect.Width,
                rect.Height,
                GraphicsUnit.Pixel,
                imAtt);
        }

        private void SetOutputChannelColorProfile_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Bitmap image = new Bitmap("car.bmp");
            ImageAttributes imAtt = new ImageAttributes();
            int width = image.Width;
            int height = image.Height;
            Rectangle rect = new Rectangle(0, 0, width, height);
            //����ԭʼͼƬ
            graphics.DrawImage(image, rect);

            graphics.TranslateTransform(width, 0);
            //����ɫ�������ļ�
            imAtt.SetOutputChannelColorProfile(
                "kodak_dc.ICM", ColorAdjustType.Bitmap);

            //ʹ��ɫ�������ļ����ͼƬ
            graphics.DrawImage(
                image,
                rect,
                0, 0, width, height,
                GraphicsUnit.Pixel,
                imAtt);
        }

        private void Gammaadjust_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //װ��ԭʼͼƬ
            Bitmap image = new Bitmap("warrior.bmp");
            int width = image.Width;
            int height = image.Height;

            // ����������Ϣ
            Font myFont = new Font("����", 12);
            //������ʾ��Ϣ����ʾ����
            PointF origin = new PointF(width + 10, height + 20);
            SolidBrush blackBrush = new SolidBrush(Color.Black);

            ImageAttributes imAtt = new ImageAttributes();
            string msg = string.Empty;
            //��0-3���ε������ͼƬʱ��ʹ�õ�Gammaֵ
            for (float i = 0.0f; i < 3.0f; i += 0.1f)
            {
                //����ԭʼͼƬ
                graphics.DrawImage(image, 0, 0);

                //����Gammaֵ
                imAtt.SetGamma(i, ColorAdjustType.Bitmap);
                //ʹ���޸ĺ�Gammaֵ����ͼƬ���
                graphics.DrawImage(
                    image,
                    new Rectangle(width + 10, 0, width, height),  //Ŀ������
                    0, 0, width, height,           //Դ����
                    GraphicsUnit.Pixel,
                    imAtt);
                msg = string.Format("�����޸�Gammaֵ��Gamma={0:F2}", i);
                //��ʾ��ǰ��Gammaֵ��Ϣ
                graphics.DrawString(msg, myFont, blackBrush, origin);
                //��ʱһ���Ա�ۿ�Ч��
                Thread.Sleep(100);
                graphics.Clear(Color.White);
                imAtt.ClearGamma();
            }

        }

        private void SetOutputChannel_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //װ��ͼƬ
            Bitmap image = new Bitmap("jieba.bmp");
            //ͼƬ�ĸ߶�
            int width = image.Width;
            int height = image.Height;

            //����ԭʼͼƬ
            graphics.DrawImage(image, new RectangleF(0, 0, width, height));
            ImageAttributes imAtt = new ImageAttributes();
            //����ɫ�����ͨ��cyan
            imAtt.SetOutputChannel(ColorChannelFlag.ColorChannelC,
                ColorAdjustType.Bitmap);
            //���ƣ�����ͼƬ
            graphics.TranslateTransform(width, 0);
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, width, height),
                0, 0, width, height,
                GraphicsUnit.Pixel,
                imAtt);

            //����ɫ�����ͨ��:magenta 
            imAtt.SetOutputChannel(ColorChannelFlag.ColorChannelM,
                ColorAdjustType.Bitmap);
            //���ƣ�����ͼƬ
            graphics.TranslateTransform(width, 0);
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, width, height),
                0, 0, width, height,
                GraphicsUnit.Pixel,
                imAtt);

            //����ɫ�����ͨ��:yellow
            imAtt.SetOutputChannel(ColorChannelFlag.ColorChannelY,
                ColorAdjustType.Bitmap);
            //���ƣ�����ͼƬ
            graphics.TranslateTransform(width, 0);
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, width, height),
                0, 0, width, height,
                GraphicsUnit.Pixel,
                imAtt);

            //����ɫ�����ͨ��:black
            imAtt.SetOutputChannel(ColorChannelFlag.ColorChannelK,
                ColorAdjustType.Bitmap);
            //���ƣ�����ͼƬ
            graphics.TranslateTransform(width, 0);
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, width, height),
                0, 0, width, height,
                GraphicsUnit.Pixel,
                imAtt);

        }

        private void Colorkey_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //װ��ǰ�󱳾�ͼƬ
            Bitmap forground = new Bitmap("grid.bmp");
            Bitmap background = new Bitmap("snike.bmp");

            int width = background.Width;
            int height = background.Height;
            Rectangle rect = new Rectangle(0, 0, width, height);

            //����ɫ���óɹؼ�ɫ
            ImageAttributes imAtt = new ImageAttributes();
            imAtt.SetColorKey(
                Color.Red,
                Color.Red,
                ColorAdjustType.Bitmap);

            //���Ʊ���
            graphics.DrawImage(background, 0, 0);
            //����ǰ��
            graphics.DrawImage(
                forground,
                rect,
                0, 0, forground.Width, forground.Height,
                GraphicsUnit.Pixel,
                imAtt);

            graphics.TranslateTransform(width + 20, 0);
            graphics.DrawImage(background, 0, 0);
            //����Ѿ�Ӧ�õĹؼ�ɫ��Ϣ
            imAtt.ClearColorKey(ColorAdjustType.Bitmap);
            ///����ɫ���óɹؼ�ɫ
            imAtt.SetColorKey(
                Color.Blue,
                Color.Blue,
                ColorAdjustType.Bitmap);
            graphics.DrawImage(forground,
                rect,
                0, 0, forground.Width, forground.Height,
                GraphicsUnit.Pixel,
                imAtt);
            graphics.TranslateTransform(width + 20, 0);

            //����Դͼ
            graphics.DrawImage(background, 0, 0);
        }

        private void Setthreshold_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Bitmap image = new Bitmap("box-2.bmp");
            int Width = image.Width;
            int Height = image.Height;
            //����ԭʼͼƬ
            graphics.DrawImage(image, 10, 10, Width, Height);

            //����ֵ��0��1��������
            ImageAttributes imAtt = new ImageAttributes();
            for (float i = 0.0f; i < 1.0f; i += 0.1f)
            {
                //�������ͼƬʱʹ�õ���ֵ
                imAtt.SetThreshold(i, ColorAdjustType.Bitmap);
                //�����Ѿ�ʹ������ֵ��ͼƬ
                graphics.DrawImage(image,
                    new Rectangle(10 + Width, 10, Width, Height),
                    0, 0, Width, Height,
                    GraphicsUnit.Pixel,
                    imAtt);
                //��ʱ
                Thread.Sleep(1000);
            }
        }

        private void AdjustedPalette_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            graphics.ScaleTransform(0.7f, 0.7f);

            //����ͼƬ
            Bitmap image = new Bitmap("lord-256.bmp");
            //����ͼƬ
            Bitmap image2 = (Bitmap)image.Clone();
            //��ȡͼƬʹ�õĵ�ɫ����Ϣ
            ColorPalette palette = image.Palette;

            //��ȡ��ɫ����������ɫ������
            int count = palette.Entries.Length;
            if (count < 1)
            {
                MessageBox.Show("ͼƬ�޵�ɫ����Ϣ����");
                return;
            }

            //���ĵ�ɫ���е�ÿһ��ɫ����Ϣ		
            for (int i = 0; i < count; i++)
            {
                int r = palette.Entries[i].R / 2;
                int g = palette.Entries[i].G / 2;
                int b = palette.Entries[i].B / 2;

                if (r < 1)
                    r = 0;
                if (g < 1)
                    g = 0;
                if (b < 1)
                    b = 0;
                palette.Entries[i] = Color.FromArgb(255, r, g, b);
            }

            //����ͼ����µ�ɫ��
            image.Palette = palette;
            //����ԭͼ
            graphics.DrawImage(image2, 0, 0);
            //�����޸ĺ��ͼƬ
            graphics.DrawImage(image, image.Width + 10, 0);
        }

        private void SetWrapMode_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //����ͼƬ
            Bitmap image = new Bitmap("yueru.bmp");
            ImageAttributes imAtt = new ImageAttributes();

            //����ͼƬ���з�ʽΪWrapModeClamp��ͼƬ������ƽ��
            imAtt.SetWrapMode(WrapMode.Clamp, Color.Red);

            //��С��ʾԴͼ
            graphics.DrawImage(image,
                new Rectangle(0, 0, image.Width, image.Height),  //Ŀ������
                0, 0, 2 * image.Width, 2 * image.Height,      //ԴͼƬ����
                GraphicsUnit.Pixel,
                imAtt);

            graphics.TranslateTransform(image.Width + 10, 0);
            //����ͼƬ���з�ʽΪWrapModeTileFlipXY��ͼƬ��ˮƽ�ʹ�ֱ������ͬʱ��ת
            imAtt.SetWrapMode(WrapMode.TileFlipXY);
            graphics.DrawImage(image,
                new Rectangle(0, 0, image.Width, image.Height),  //Ŀ������
                0, 0, 2 * image.Width, 2 * image.Height,       //ԴͼƬ����
                GraphicsUnit.Pixel,
                imAtt);

            graphics.TranslateTransform(image.Width + 10, 0);
            //����ͼƬ���з�ʽΪWrapModeTileFlipX��ͼƬ��ˮƽ�Ϸ�ת
            imAtt.SetWrapMode(WrapMode.TileFlipX);
            graphics.DrawImage(image,
                new Rectangle(0, 0, image.Width, image.Height),  //Ŀ������
                0, 0, 2 * image.Width, 2 * image.Height,       //ԴͼƬ����
                GraphicsUnit.Pixel,
                imAtt);

            graphics.TranslateTransform(image.Width + 10, 0);
            //����ͼƬ���з�ʽΪWrapModeTileFlipY��ͼƬ�ڴ�ֱ�Ϸ�ת
            imAtt.SetWrapMode(WrapMode.TileFlipY);
            graphics.DrawImage(image,
                new Rectangle(0, 0, image.Width, image.Height),  //Ŀ������
                0, 0, 2 * image.Width, 2 * image.Height,       //ԴͼƬ����
                GraphicsUnit.Pixel,
                imAtt);
        }

        private void ListAllImageEncoders_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush brush = new SolidBrush(Color.Blue);
            FontFamily fontFamily = new FontFamily("����_GB2312_GB2312");
            Font myFont = new Font(fontFamily,
                20, FontStyle.Regular, GraphicsUnit.Pixel);

            ImageCodecInfo[] pImageCodecInfo;
            //��ȡ��������Ϣ
            pImageCodecInfo = ImageCodecInfo.GetImageEncoders();

            //���������Ϣ
            string msg = string.Empty;
            for (int j = 0; j < pImageCodecInfo.GetLength(0); ++j)
            {
                msg += string.Format("����������:{0}\t�ļ���ʽ��չ��:{1}\t\n",
                    pImageCodecInfo[j].CodecName, pImageCodecInfo[j].FilenameExtension);
            }
            graphics.DrawString(msg, myFont, brush,
                new PointF(0, 0));
        }

        private void ListImageEncoder_Detail_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            ImageCodecInfo[] pImageCodecInfo;
            //��ȡ��������Ϣ
            pImageCodecInfo = ImageCodecInfo.GetImageEncoders();
            int sigCount;
            int j, k;
            j = 0;
            k = 0;
            string msg = string.Empty;
            //��ѯ���еı�������Ϣ
            for (j = 0; j < pImageCodecInfo.GetLength(0); ++j)
            {
                msg += string.Format("��ʼ������{0}��ͼ�α�����Ϣ\n\n", j);
                msg += string.Format("�����ʶ: {0}\n",
                    pImageCodecInfo[j].Clsid);
                msg += string.Format("�ļ���ʽ��ʶ: {0}\n",
                    pImageCodecInfo[j].FormatID);
                msg += string.Format("����������: {0}\n",
                    pImageCodecInfo[j].CodecName);
                msg += string.Format("����������Ķ�̬���ӿ���: {0}\n",
                    pImageCodecInfo[j].DllName);
                msg += string.Format("��������: {0}\n",
                    pImageCodecInfo[j].FormatDescription);
                msg += string.Format("��������Ӧ���ļ���չ��: {0}\n",
                    pImageCodecInfo[j].FilenameExtension);
                msg += string.Format("��������MIME��������: {0}\n",
                    pImageCodecInfo[j].MimeType);
                msg += string.Format("ImageCodecFlagsö�ٵı�Ǽ�: {0}\n",
                    pImageCodecInfo[j].Flags.ToString());
                msg += string.Format("�������汾: {0}\n",
                    pImageCodecInfo[j].Version);

                sigCount = pImageCodecInfo[j].SignaturePatterns.GetLength(0);
                msg += string.Format("���������Ӧ�ı�����ǩ���������С:{0}\n", sigCount);
                msg += string.Format("��{0}��ͼ�α�����Ϣ�������\n\n", j);

            }

            //������������ϸ��Ϣд���ļ�
            StreamWriter sw = new StreamWriter(@"listinfo.txt", false, System.Text.Encoding.Unicode);
            sw.Write(msg);
            sw.Close();
            MessageBox.Show("������������򿪵�ǰĿ¼�µ�listinfo.txt�鿴��������Ϣ");
        }

        private void ListImageDecoder_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush brush = new SolidBrush(Color.Blue);
            FontFamily fontFamily = new FontFamily("����_GB2312_GB2312");
            Font myFont = new Font(fontFamily,
                20, FontStyle.Regular, GraphicsUnit.Pixel);

            ImageCodecInfo[] pImageCodecInfo;
            //��ȡ��������Ϣ
            pImageCodecInfo = ImageCodecInfo.GetImageDecoders();

            //���ÿһ������������ϸ��Ϣ
            string msg = string.Empty;
            for (int j = 0; j < pImageCodecInfo.GetLength(0); ++j)
            {
                msg += string.Format("����������:{0}\t�ļ���ʽ��չ��:{1}\t\n",
                    pImageCodecInfo[j].CodecName, pImageCodecInfo[j].FilenameExtension);

            }

            //��ʾ��Ϣ
            graphics.DrawString(msg, myFont, brush,
                new PointF(0, 0));
        }
        private Guid GetEncoderClsid(string format)
        {
            Guid picGUID = new Guid();
            ImageCodecInfo[] pImageCodecInfo; ;
            //��ȡ��������Ϣ
            pImageCodecInfo = ImageCodecInfo.GetImageEncoders();
            //����ָ����ʽ�ļ��ı�������Ϣ
            for (int i = 0; i < pImageCodecInfo.GetLength(0); ++i)
            {	//MimeType�����뷽ʽ�ľ�������
                if (format.CompareTo(pImageCodecInfo[i].MimeType.ToString()) == 0)
                {
                    picGUID = pImageCodecInfo[i].Clsid;
                }
            }
            return picGUID;
        }

        private void GetEncoderParameter_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush brush = new SolidBrush(Color.Blue);
            FontFamily fontFamily = new FontFamily("����");
            Font myFont = new Font(fontFamily, 16, FontStyle.Regular, GraphicsUnit.Pixel);

            string msg = string.Empty;
            // Ϊ�˲�ѯ��λͼ����ΪJPEG��ʽ��ͼƬ���½�һ��λͼ
            Bitmap bitmap = new Bitmap(1, 1);

            //��ȡJPEG��ʽ��ͼ��������ı�ʶ
            Guid encoderClsid = new Guid();
            encoderClsid = GetEncoderClsid("image/png");

            // ��ȡת����JPG����Ҫ�ľ��������Ϣ
            EncoderParameters pEncoderParameters = new EncoderParameters();
            pEncoderParameters = bitmap.GetEncoderParameterList(encoderClsid);
            // �鿴pEncoderParameters�����ж��ٸ�EncoderParameter��
            int count = pEncoderParameters.Param.GetLength(0);
            msg += string.Format("�ڱ��������������{0}��EncoderParameter��\nÿ�������ϸ��ϢΪ��\n", count);

            EncoderParameter[] pEncoderParameter = pEncoderParameters.Param;
            /*�ֱ�鿴EncoderParameters�����е�
            ÿһ��EncoderParameter����ĳ�Ա����
            GUID��NumberOfValues��Type*/
            for (int i = 0; i < count; i++)
            {
                //��GUIDֵת�����ִ� 
                msg += string.Format("�������õĵ�{0}����������(GUID):{1}s\n", i, pEncoderParameter[i].Encoder.Guid);
                //�鿴��ÿһ�����������£��������õĲ�����Ϣ
                msg += string.Format("\t�ڸò������������£�����Խ��е����õĲ����ֱ�����\n");
                msg += string.Format("\t\t��������={0}\n", pEncoderParameter[i].NumberOfValues);
                msg += string.Format("\t\t��������={0}\n", pEncoderParameter[i].Type.ToString());
            }
            //�����������б���Ϣ
            graphics.DrawString(msg, myFont, brush,
                new PointF(0, 0));
            MessageBox.Show(msg);
            MessageBox.Show(Encoder.ChrominanceTable.Guid.ToString());
        }
        private string EncoderParameterCategoryFromGUID(Guid guid)
        {
            string ParameterCategory = string.Empty;
            if (guid == Encoder.Compression.Guid)
                ParameterCategory = "Compression";
            else if (guid == Encoder.ColorDepth.Guid)
                ParameterCategory = "ColorDepth";
            else if (guid == Encoder.ScanMethod.Guid)
                ParameterCategory = "ScanMethod";
            else if (guid == Encoder.Version.Guid)
                ParameterCategory = "Version";
            else if (guid == Encoder.RenderMethod.Guid)
                ParameterCategory = "RenderMethod";
            else if (guid == Encoder.Quality.Guid)
                ParameterCategory = "Quality";
            else if (guid == Encoder.Transformation.Guid)
                ParameterCategory = "Transformation";
            else if (guid == Encoder.LuminanceTable.Guid)
                ParameterCategory = "LuminanceTable";
            else if (guid == Encoder.ChrominanceTable.Guid)
                ParameterCategory = "ChrominanceTable";
            else if (guid == Encoder.SaveFlag.Guid)
                ParameterCategory = "SaveFlag";
            else
                ParameterCategory = "Unknown category";
            return ParameterCategory;
        }

        private string ShowAllEncoderParameters(string format)
        {
            string outmsg = string.Empty;

            //��λͼΪ�����鿴pImageCodecInfo����ϸ��Ϣ	
            Bitmap bitmap = new Bitmap("head.bmp");
            EncoderParameters encodersarameters = new EncoderParameters();

            // ��ȡ��������Ĳ����б�
            encodersarameters = bitmap.GetEncoderParameterList(GetEncoderClsid(format));
            //��ȡEncoderParameter��������
            int count = encodersarameters.Param.GetLength(0);
            outmsg += string.Format("��EncoderParameters�У���{0}�� EncoderParameter����\n",
                count);
            EncoderParameter[] pEncoderParameter;
            pEncoderParameter = encodersarameters.Param;

            // �鿴ÿһ��EncoderParameter������Ϣ
            for (int k = 0; k < count; ++k)
            {
                //��ԭGUID��Ϣ
                string strParameterCategory = EncoderParameterCategoryFromGUID(
                    pEncoderParameter[k].Encoder.Guid);
                outmsg += string.Format("\t��������: {0}.\n", strParameterCategory);
                outmsg += string.Format("\t�ò���������ֵһ���� {0}��\n",
                    pEncoderParameter[k].NumberOfValues);
                outmsg += string.Format("\t��������{0}.\n", pEncoderParameter[k].Type);
            }
            //��������Ϣ����outmsg
            return outmsg;
        }

        private void GetAllEncoderParameter_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //���������Ϣʱʹ�õ����塢��ˢ
            SolidBrush brush = new SolidBrush(Color.Blue);
            FontFamily fontFamily = new FontFamily("����");
            Font myFont = new Font(fontFamily, 16,
                FontStyle.Regular, GraphicsUnit.Pixel);

            //�������б���ϸ��Ϣ���浽msg֮��
            string msg = ShowAllEncoderParameters("image/jpeg");
            //��ʾ�����б���Ϣ
            graphics.DrawString(msg, myFont, Brushes.Black,
                new PointF(0, 0));
        }

        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }

        private void menuItem17_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Bitmap image = new Bitmap("snike.bmp");
            RectangleF rect = new RectangleF(0, 0, image.Width / 2, image.Height / 2);
            graphics.DrawImage(image, rect);

            ImageCodecInfo myImageCodecInfo;
            myImageCodecInfo = GetEncoderInfo("image/png");
            //��BMP����ΪPNG�ļ�,��ʹ�ñ������
            image.Save("snike.png", myImageCodecInfo, new EncoderParameters(0));

            //ʹ�õڶ��ַ�������encoder����
            image.Save("snike2.png", ImageFormat.Png);

            //�ֱ�����ַ��������ͼ��
            Bitmap image_png1 = new Bitmap("snike.png");
            Bitmap image_png2 = new Bitmap("snike2.png");

            //����PNG��ʽ��ͼƬ
            graphics.TranslateTransform(rect.Width, 0);
            graphics.DrawImage(image_png1, rect);
            graphics.TranslateTransform(rect.Width, 0);
            graphics.DrawImage(image_png2, rect);

        }

        private void SaveBmp2tif_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Bitmap myBitmap;
            ImageCodecInfo myImageCodecInfo;
            Encoder myEncoder;
            EncoderParameter myEncoderParameter;
            EncoderParameters myEncoderParameters;

            myBitmap = new Bitmap("jieba.bmp");
            // ��ȡTIFF��ʽ�ļ��ı�����Ϣ
            myImageCodecInfo = GetEncoderInfo("image/tiff");

            // ����һ������ѹ����ʽ�Ĳ�������
            myEncoder = Encoder.Compression;
            myEncoderParameters = new EncoderParameters(1);
            // ʹ��LZWѹ����ʽ��ͼͼ��Ϊ TIFF�ļ�
            myEncoderParameter = new EncoderParameter(
                myEncoder,
                (long)EncoderValue.CompressionLZW);
            myEncoderParameters.Param[0] = myEncoderParameter;
            myBitmap.Save("jieba.tif", myImageCodecInfo, myEncoderParameters);
        }

        private void SaveBMP2JPG_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Bitmap myBitmap;
            ImageCodecInfo myImageCodecInfo;
            Encoder myEncoder;
            EncoderParameter myEncoderParameter;
            EncoderParameters myEncoderParameters;

            //��BMP�ļ�
            myBitmap = new Bitmap("car.bmp");
            //��ȡ��ʾͼƬ����Ҫ����
            Rectangle imgrect = new Rectangle(0, 0,
                myBitmap.Width, myBitmap.Height);

            graphics.DrawImage(myBitmap, imgrect);

            //��ȡJPEG��ʽ�ı��뷽ʽ
            myImageCodecInfo = GetEncoderInfo("image/jpeg");

            //�ֱ�����JPEG�ļ���ͼƬ����
            //�����������ΪQuality
            myEncoder = Encoder.Quality;
            //����һ��EncoderParameters������������һ�� EncoderParameter����
            myEncoderParameters = new EncoderParameters(1);

            //����JPEGͼƬ����Ϊ25��
            myEncoderParameter = new EncoderParameter(myEncoder, 25L);
            myEncoderParameters.Param[0] = myEncoderParameter;
            myBitmap.Save("car025.jpg", myImageCodecInfo, myEncoderParameters);

            //����JPEGͼƬ����Ϊ50��
            myEncoderParameter = new EncoderParameter(myEncoder, 50L);
            myEncoderParameters.Param[0] = myEncoderParameter;
            myBitmap.Save("car050.jpg", myImageCodecInfo, myEncoderParameters);

            //����JPEGͼƬ����Ϊ75��
            myEncoderParameter = new EncoderParameter(myEncoder, 75L);
            myEncoderParameters.Param[0] = myEncoderParameter;
            myBitmap.Save("car075.jpg", myImageCodecInfo, myEncoderParameters);

            //�ֱ���ʾ��ͬͼƬ������JPEG�ļ�
            Bitmap image01 = new Bitmap("car025.jpg");
            //��ͼƽ������
            graphics.TranslateTransform(imgrect.Width + 10, 0);
            graphics.DrawImage(image01, imgrect);

            Bitmap image02 = new Bitmap("car050.jpg");
            //���û�ͼƽ�棬����
            graphics.ResetTransform();

            graphics.TranslateTransform(0, imgrect.Height + 10);
            graphics.DrawImage(image02, imgrect);

            Bitmap image05 = new Bitmap("car075.jpg");
            graphics.TranslateTransform(imgrect.Width + 10, 0);
            graphics.DrawImage(image02, imgrect);
        }

        private void TransformingJPEG_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Bitmap myBitmap;
            ImageCodecInfo myImageCodecInfo;
            Encoder myEncoder;
            EncoderParameter myEncoderParameter;
            EncoderParameters myEncoderParameters;

            //��JPEG�ļ�
            myBitmap = new Bitmap("car.jpg");
            //��ȡ��ʾͼƬ����Ҫ����
            Rectangle imgrect = new Rectangle(0, 0,
                myBitmap.Width, myBitmap.Height);
            //����ԭͼ
            graphics.DrawImage(myBitmap, imgrect);

            //��ȡJPEG��ʽ�ı��뷽ʽ
            myImageCodecInfo = GetEncoderInfo("image/jpeg");

            //�ֱ�����JPEG�ļ���λ�ñ任��Ϣ
            //�����������ΪTransformation
            myEncoder = Encoder.Transformation;
            //����һ��EncoderParameters������������һ�� EncoderParameter����
            myEncoderParameters = new EncoderParameters(1);

            // ��ͼƬ��ת90�Ⱥ󱣴�
            myEncoderParameter = new EncoderParameter(
                myEncoder, (long)EncoderValue.TransformRotate270);
            myEncoderParameters.Param[0] = myEncoderParameter;
            myBitmap.Save("car0_rotate.jpg", myImageCodecInfo, myEncoderParameters);

            //������ת���ͼƬ
            graphics.TranslateTransform(imgrect.Width, 0);
            myBitmap = new Bitmap("car0_rotate.jpg");
            //��ȡ��ʾͼƬ����Ҫ����
            imgrect = new Rectangle(0, 0,
                myBitmap.Width, myBitmap.Height);
            graphics.DrawImage(myBitmap, imgrect);
        }


        private void MultipleFrameImage_Click(object sender, System.EventArgs e)
        {
            Bitmap multi;
            Bitmap page2;
            Bitmap page3;
            Bitmap page4;

            ImageCodecInfo myImageCodecInfo;
            Encoder myEncoder;
            EncoderParameter myEncoderParameter;
            EncoderParameters myEncoderParameters;

            //װ�����Ų�ͬ��ʽ��ͼƬ
            multi = new Bitmap("dog.bmp");
            page2 = new Bitmap("dog.gif");
            page3 = new Bitmap("cute.jpg");
            page4 = new Bitmap("cat.png");

            //��ȡtiffͼ���ʽ�ı�����Ϣ
            myImageCodecInfo = GetEncoderInfo("image/tiff");

            //�������ͣ�SaveFlag
            myEncoder = Encoder.SaveFlag;
            //����һ��EncoderParameters������������һ�� EncoderParameter����
            myEncoderParameters = new EncoderParameters(1);

            //�����һ��ͼƬ
            myEncoderParameter = new EncoderParameter(
                myEncoder,
                (long)EncoderValue.MultiFrame);
            myEncoderParameters.Param[0] = myEncoderParameter;
            multi.Save("Multiframe.tiff", myImageCodecInfo, myEncoderParameters);

            //����ڶ���ͼƬ
            myEncoderParameter = new EncoderParameter(
                myEncoder,
                (long)EncoderValue.FrameDimensionPage);
            myEncoderParameters.Param[0] = myEncoderParameter;
            multi.SaveAdd(page2, myEncoderParameters);

            //���������ͼƬ
            myEncoderParameter = new EncoderParameter(
                myEncoder,
                (long)EncoderValue.FrameDimensionPage);
            myEncoderParameters.Param[0] = myEncoderParameter;
            multi.SaveAdd(page3, myEncoderParameters);

            //���������ͼƬ
            myEncoderParameter = new EncoderParameter(
                myEncoder,
                (long)EncoderValue.FrameDimensionPage);
            myEncoderParameters.Param[0] = myEncoderParameter;
            multi.SaveAdd(page4, myEncoderParameters);

            // �ر�TIFF�ļ�
            myEncoderParameter = new EncoderParameter(
                myEncoder,
                (long)EncoderValue.Flush);
            myEncoderParameters.Param[0] = myEncoderParameter;
            multi.SaveAdd(myEncoderParameters);
            MessageBox.Show("������������򿪵�ǰĿ¼�µ�Multiframe.tiff�鿴ͼƬ��ӽ��");
        }
        private void GetImageFromMultyFrame_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //�������зֳ��ĸ����֣�������ʾ�ķ�֡ͼƬ
            Rectangle ClientRect = new Rectangle(0, 0,
                this.ClientSize.Width, this.ClientSize.Height);
            Rectangle r1 = new Rectangle(0, 0,
                ClientRect.Width / 2, ClientRect.Height / 2);
            Rectangle r2 = new Rectangle(ClientRect.Width / 2, 0,
                ClientRect.Width / 2, ClientRect.Height / 2);
            Rectangle r3 = new Rectangle(0,
                ClientRect.Height / 2, ClientRect.Width / 2, ClientRect.Height / 2);
            Rectangle r4 = new Rectangle(ClientRect.Width / 2,
                ClientRect.Height / 2, ClientRect.Width / 2, ClientRect.Height / 2);

            //��TIF�ļ�
            Bitmap multi = new Bitmap("Multiframe.tiff");

            //FrameDimension.Page:��֡ͼƬ
            FrameDimension pageGuid = FrameDimension.Page;

            //��ʾ�������һ֡ͼƬ
            multi.SelectActiveFrame(pageGuid, 0);
            graphics.DrawImage(multi, r1);
            multi.Save("Page0.png", ImageFormat.Png);

            //��ʾ������ڶ�֡ͼƬ
            multi.SelectActiveFrame(pageGuid, 1);
            graphics.DrawImage(multi, r2);
            multi.Save("Page1.png", ImageFormat.Png);

            ////��ʾ���������֡ͼƬ
            multi.SelectActiveFrame(pageGuid, 2);
            graphics.DrawImage(multi, r3);
            multi.Save("Page2.png", ImageFormat.Png);

            ////��ʾ���������֡ͼƬ
            multi.SelectActiveFrame(pageGuid, 3);
            graphics.DrawImage(multi, r4);
            multi.Save("Page3.png", ImageFormat.Png);
        }

        private void QueryImage_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush brush = new SolidBrush(Color.Black);
            FontFamily fontFamily = new FontFamily("����");
            Font myFont = new Font(fontFamily, 16, FontStyle.Regular, GraphicsUnit.Pixel);

            int count = 0;
            Bitmap image = new Bitmap("car.jpg");
            //��ȡͼ���������
            PropertyItem[] propItem = image.PropertyItems;

            // ͼ���й��ж����������ɹ���ѯ
            count = propItem.GetLength(0);
            if (count == 0)
            {
                MessageBox.Show("���������ɹ���ѯ");
                return;
            }

            string tmp = string.Empty;
            for (int j = 0; j < count; ++j)
            {
                tmp += string.Format("��{0}���ɹ�����ѯ���������ı��ֵΪ��16���ƣ���{1:X}\n",
                    j, propItem[j].Id);
                tmp += string.Format("��{0}����������Ӧ�����������ϢΪ��\n", j);

                //��ȡ��������ϸ������Ϣ
                tmp += string.Format("\t������ĳ���Ϊ{0}\n\t��������Ϊ{1}\n",
                    propItem[j].Len, propItem[j].Type.ToString());
            }

            //���ͼ���������Ϣ
            graphics.DrawString(tmp, myFont, brush,
                new PointF(0, 0));
        }

        private void SetProp_Click(object sender, System.EventArgs e)
        {
            //װ��ͼƬ�Թ��޸�
            Bitmap image = new Bitmap("car.jpg");

            // ����ͼƬ������ΪJasmine
            byte[] newWriterValue = {(byte)'J', (byte)'a',
								(byte)'s', (byte)'m', (byte)'i', (byte)'e'};

            PropertyItem[] pp = image.PropertyItems;

            //0x13b���ñ��ֵ��ӦͼƬ����
            pp[0].Id = 0x13b;
            //����ֵ����
            pp[0].Len = newWriterValue.GetLength(0);
            //2������ֵ����������Ϊ�ַ���
            pp[0].Type = 2;
            pp[0].Value = newWriterValue;

            //����ͼƬ����
            image.SetPropertyItem(pp[0]);
            image.Save("newwriter.jpg");

            //���¼����޸ĺ��ͼƬ
            Bitmap image2 = new Bitmap("newwriter.jpg");
            //�鿴ͼƬ��������Ϣ
            pp[1] = image2.GetPropertyItem(0x13b);
            string msg = string.Empty;
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            string manufacturer = encoding.GetString(pp[1].Value);
            msg = string.Format("ͼƬ�������Ѿ�����Ϊ\n{0}", manufacturer);
            MessageBox.Show(msg);
        }

        private void OnCanvas_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            graphics.ScaleTransform(0.7f, 0.7f);

            Bitmap image = new Bitmap("box-2.bmp");

            int Width = image.Width;
            int Height = image.Height;
            Color color;
            graphics.DrawImage(image,
                new Rectangle(0, 0, Width, Height));

            //�������������
            Random rand = new Random();
            for (int i = 0; i < Width - 5; i++)
            {
                for (int j = 0; j < Height - 5; j++)
                {
                    int a = rand.Next(1000) % 5;

                    color = image.GetPixel(i + a, j + a);
                    //���õ��RGBֵ���óɸ������֮�ڵ���һ��
                    image.SetPixel(i, j, color);
                }
                //��̬�����˾�Ч��ͼ
                graphics.DrawImage(image,
                    new Rectangle(Width, 0, Width, Height));
            }

        }

        private void OnWood_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            graphics.ScaleTransform(0.7f, 0.7f);

            Bitmap image = new Bitmap("box-2.bmp");

            int Width = image.Width;
            int Height = image.Height;
            Color colorTemp, color2;
            Color color;
            //����ԭͼ
            graphics.DrawImage(
                image, new Rectangle(0, 0, Width, Height));
            int tmp;
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    color = image.GetPixel(i, j);
                    //���ݸõ�RGB��ƽ��ֵ��ȷ�ϸõ�ġ�������
                    int avg;
                    avg = (color.R + color.G + color.B) / 3;
                    if (avg >= 128)
                        tmp = 255;
                    else
                        tmp = 0;
                    colorTemp = Color.FromArgb(255, tmp, tmp, tmp);
                    //��������RGBֵ��д��λͼ
                    image.SetPixel(i, j, colorTemp);
                }
                //��̬�����˾�Ч��ͼ
                graphics.DrawImage(
                    image, new Rectangle(Width, 0, Width, Height));
            }

        }
        //��������A��B֮��ľ��Ծ���
        float fDistance(Point A, Point B)
        {
            double i = Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2);
            return (float)Math.Sqrt(i);
        }

        private void Flashligt_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Bitmap image = new Bitmap("sports.bmp");
            int Width = image.Width;
            int Height = image.Height;
            int A = Width / 2;
            int B = Height / 2;
            //Center:ͼƬ���ĵ㣬������ֵ����ǿ�����ķ���ƫ��
            Point Center = new Point(A, B);
            //R��ǿ��������İ뾶���������Ρ�
            int R = 100;
            Color colorTemp, color2;
            Color color;
            graphics.DrawImage(
                image, new Rectangle(0, 0, Width, Height));
            //���η���ÿ������
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Point tmp = new Point(x, y);
                    //�������λ�ڡ����Ρ�֮��
                    if (fDistance(tmp, Center) < R)
                    {
                        color = image.GetPixel(x, y);
                        int r, g, b;
                        //���ݸõ����ǿ�����ĵ�ľ��룬�ֱ���RGBֵ����
                        //220:�������ӳ�������ֵԽ�󣬹�����Խǿ
                        float tmp_r = 220.0f * (1.0f - fDistance(tmp, Center) / R);

                        r = color.R + (int)tmp_r;
                        r = Math.Max(0, Math.Min(r, 255));

                        g = color.G + (int)tmp_r;
                        g = Math.Max(0, Math.Min(g, 255));
                        b = color.B + (int)tmp_r;
                        b = Math.Max(0, Math.Min(b, 255));

                        colorTemp = Color.FromArgb(255, (int)r, (int)g, (int)b);
                        //�������������ֵ��д��λͼ
                        image.SetPixel(x, y, colorTemp);
                    }
                }
                //��̬�����˾�Ч��ͼ
                graphics.DrawImage(
                    image, new Rectangle(Width, 0, Width, Height));
            }
            /*����ڴ˴�ʹ��graphics.DrawImage(
            image, new Rectangle(Width, 0, Width, Height));
            ���ƹ����Ǿ�̬��*/



        }

        private void BlurAndSharpen_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            graphics.ScaleTransform(0.8f, 0.8f);

            Bitmap image = new Bitmap("snike.bmp");

            int Width = image.Width;
            int Height = image.Height;
            //image2:�����񻯴���
            Bitmap image2 = (Bitmap)image.Clone();

            Color colorTemp;
            Color[,] color = new Color[3, 3];
            //����ԭͼ
            graphics.DrawImage(
                image, new Rectangle(0, 0, Width, Height));

            for (int i = 1; i < Width - 2; i++)
            {
                for (int j = 1; j < Height - 2; j++)
                {
                    //������Χ9�����RGBֵ
                    color[0, 0] = image.GetPixel(i - 1, j - 1);
                    color[0, 1] = image.GetPixel(i - 1, j);
                    color[0, 2] = image.GetPixel(i - 1, j + 1);

                    color[1, 0] = image.GetPixel(i, j - 1);
                    color[1, 1] = image.GetPixel(i, j);
                    color[1, 2] = image.GetPixel(i, j + 1);

                    color[2, 0] = image.GetPixel(i + 1, j - 1);
                    color[2, 1] = image.GetPixel(i + 1, j);
                    color[2, 2] = image.GetPixel(i + 1, j + 1);

                    int rSum = 0;
                    int gSum = 0;
                    int bSum = 0;
                    //�ֱ������Χ9�����R��G��B֮��
                    for (int n = 0; n < 3; n++)
                        for (int nn = 0; nn < 3; nn++)
                        {
                            rSum += color[n, nn].R;
                            gSum += color[n, nn].G;
                            bSum += color[n, nn].B;
                        }
                    //��RGB��ƽ��ֵ��Ϊ��ǰ���RGBֵ
                    colorTemp = Color.FromArgb(255,
                        (int)(rSum / 9), (int)(gSum / 9), (int)(bSum / 9));
                    //��������RGBֵ��д��λͼ
                    image.SetPixel(i, j, colorTemp);
                }
                //���ƾ���ƽ�������Ч��ͼ
                graphics.DrawImage(
                    image, new Rectangle(Width, 0, Width, Height));
            }

            //�����񻯴���
            Color colorLeft, colornow;
            //����dep����ϵ������ֵԽ����Ч��Խ����
            float dep = 0.550f;
            for (int i = 1; i < Width - 1; i++)
            {
                for (int j = 1; j < Height - 1; j++)
                {
                    colornow = image2.GetPixel(i, j);
                    colorLeft = image2.GetPixel(i - 1, j - 1);

                    float r = colornow.R + (colornow.R
                        - colorLeft.R * dep);
                    r = Math.Min(255, Math.Max(0, r));

                    float g = colornow.G + (colornow.G
                        - colorLeft.G * dep);
                    g = Math.Min(255, Math.Max(0, g));
                    float b = colornow.B + (colornow.B
                        - colorLeft.B * dep);
                    b = Math.Min(255, Math.Max(0, b));

                    colorTemp = Color.FromArgb(255, (int)r, (int)g, (int)b);

                    //��������RGBֵ��д��λͼ
                    image2.SetPixel(i, j, colorTemp);
                }

                graphics.DrawImage(
                    image2, new Rectangle(Width * 2, 0, Width, Height));

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}	
